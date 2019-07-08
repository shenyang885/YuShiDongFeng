using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using 余氏东风.Models;


namespace 余氏东风.ViewModels.ShopCensusVMs
{
    public partial class ShopCensusTemplateVM : BaseTemplateVM
    {
        [Display(Name = "流水日期")]
        public ExcelPropety Riqi_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.Riqi);
        [Display(Name = "流水来源")]
        public ExcelPropety Type_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.Type);
        [Display(Name = "微信转账手续费")]
        public ExcelPropety WXZZFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.WXZZFee);
        [Display(Name = "现金收支")]
        public ExcelPropety XjFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.XjFee);
        [Display(Name = "微信收支")]
        public ExcelPropety WxFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.WxFee);
        [Display(Name = "刷卡收支")]
        public ExcelPropety SkFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.SkFee);
        [Display(Name = "支付宝收支")]
        public ExcelPropety ZfbFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.ZfbFee);
        [Display(Name = "总收支")]
        public ExcelPropety SumFee_Excel = ExcelPropety.CreateProperty<ShopCensus>(x => x.SumFee);

	    protected override void InitVM()
        {
        }

    }

    public class ShopCensusImportVM : BaseImportVM<ShopCensusTemplateVM, ShopCensus>
    {

    }

}
