using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using 余氏东风.Models;


namespace 余氏东风.ViewModels.ShopVMs
{
    public partial class ShopListVM : BasePagedListVM<Shop_View, ShopSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Shop", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<Shop_View>> InitGridHeader()
        {
            return new List<GridColumn<Shop_View>>{
                this.MakeGridHeader(x => x.Riqi),
                this.MakeGridHeader(x => x.Type),
                this.MakeGridHeader(x => x.FkRenYuan),
                this.MakeGridHeader(x => x.SkRenYuan),
                this.MakeGridHeader(x => x.WXZZFee),
                this.MakeGridHeader(x => x.XjFee),
                this.MakeGridHeader(x => x.WxFee),
                this.MakeGridHeader(x => x.SkFee),
                this.MakeGridHeader(x => x.ZfbFee),
                this.MakeGridHeader(x => x.SumFee),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Shop_View> GetSearchQuery()
        {
            var query = DC.Set<Shop>()
                //.CheckEqual(Searcher.Riqi, x=>x.Riqi)
                //.CheckContain(Searcher.FkRenYuan, x=>x.FkRenYuan)
                //.CheckContain(Searcher.SkRenYuan, x=>x.SkRenYuan)
                .Select(x => new Shop_View
                {
				    ID = x.ID,
                    Riqi = x.Riqi,
                    Type = x.Type,
                    FkRenYuan = x.FkRenYuan,
                    SkRenYuan = x.SkRenYuan,
                    WXZZFee = x.WXZZFee,
                    XjFee = x.XjFee,
                    WxFee = x.WxFee,
                    SkFee = x.SkFee,
                    ZfbFee = x.ZfbFee,
                    SumFee = x.SumFee,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Shop_View : Shop{

    }
}
