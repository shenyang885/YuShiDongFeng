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
using 余氏东风.ViewModels.ShopCensusVMs;

namespace 余氏东风.ViewModels
{
    public class Listvm : BasePagedListVM<ShopCensus, ShopCensusSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            var actions = new List<GridAction>
            {
                this.MakeStandardAction("ShopCensus", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
            return actions;
        }
        protected override IEnumerable<IGridColumn<ShopCensus>> InitGridHeader()
        {
            return new List<GridColumn<ShopCensus>>{
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
            var sql = string.Format(@"select cast(year(CreateTime) as varchar)+'-'+cast(month(CreateTime) as varchar)+'-'+cast(day(CreateTime) as varchar) time,
            cast(sum(WXZZFee) as decimal(18, 2)) WXZZFee, sum(XjFee) XjFee, sum(WxFee) WxFee, sum(SkFee) SkFee, sum(ZfbFee) ZfbFee, cast(sum(SumFee) as decimal(18, 2)) SumFee
            from Shops group by year(CreateTime), month(CreateTime), day(CreateTime)");
            //var sql = string.Format("SELECT top 10 * from actionlogs");
            var cmd = DC.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }
    }
}
