using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using 余氏东风.Models;
using System.Globalization;
using System.Data.Common;
using System.Data;

namespace 余氏东风.ViewModels.ShopCensusVMs
{
 

    public partial class ShopCensusListVM : BasePagedListVM<ShopCensus_View, ShopCensusSearcher>
    {
        public ShopCensusListVM()
        {
            DetailGridPrix = "ShopCensuss";
        }
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<ShopCensus_View>> InitGridHeader()
        {
            return new List<GridColumn<ShopCensus_View>>{
                this.MakeGridHeader(x => x.Riqi),
                this.MakeGridHeader(x => x.Type),
                this.MakeGridHeader(x => x.WXZZFee),
                this.MakeGridHeader(x => x.XjFee),
                this.MakeGridHeader(x => x.WxFee),
                this.MakeGridHeader(x => x.SkFee),
                this.MakeGridHeader(x => x.ZfbFee),
                this.MakeGridHeader(x => x.SumFee),
                this.MakeGridHeaderAction(width: 200)
            };
        }
        public override DbCommand GetSearchCommand()
        {
            return base.GetSearchCommand();
        }
        public override IOrderedQueryable<ShopCensus_View> GetSearchQuery()
        {

            var query1 = DC.RunSQL(@"select cast(year(CreateTime) as varchar)+'-'+cast(month(CreateTime) as varchar)+'-'+cast(day(CreateTime) as varchar) time,
            cast(sum(WXZZFee) as decimal(18, 2)) WXZZFee, sum(XjFee) XjFee, sum(WxFee) WxFee, sum(SkFee) SkFee, sum(ZfbFee) ZfbFee, cast(sum(SumFee) as decimal(18, 2)) SumFee
            from Shops group by year(CreateTime), month(CreateTime), day(CreateTime)");
            List<ShopCensus_View> list = new List<ShopCensus_View>();
            ShopCensus_View sv;
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            foreach (System.Data.DataRow row in query1.Rows)
            {
                sv = new ShopCensus_View();
                sv.ID = new Guid();
                sv.Riqi = Convert.ToDateTime(row[0], dtFormat);
                sv.WXZZFee = float.Parse(row[1] + "");
                sv.XjFee = float.Parse(row[2] + "");
                sv.WxFee = float.Parse(row[3] + "");
                sv.SkFee = float.Parse(row[4] + "");
                sv.ZfbFee = float.Parse(row[5] + "");
                sv.SumFee = float.Parse(row[6] + "");
                sv.Type = CensusTypeEnum.QB;
                list.Add(sv);
            }
            var query = list.AsQueryable()
          .OrderBy(x => x.ExcelIndex);
            return query;
        }

    }

    public class ShopCensus_View : ShopCensus{

    }
}
