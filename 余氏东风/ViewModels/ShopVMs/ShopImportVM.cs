using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using 余氏东风.Models;


namespace 余氏东风.ViewModels.ShopVMs
{
    public partial class ShopTemplateVM : BaseTemplateVM
    {
        [Display(Name = "流水日期")]
        public ExcelPropety Riqi_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Riqi);
        [Display(Name = "流水来源")]
        public ExcelPropety Type_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Type);
        [Display(Name = "付款人")]
        public ExcelPropety FkRenYuan_Excel = ExcelPropety.CreateProperty<Shop>(x => x.FkRenYuan);
        [Display(Name = "收款人")]
        public ExcelPropety SkRenYuan_Excel = ExcelPropety.CreateProperty<Shop>(x => x.SkRenYuan);
        [Display(Name = "费用名称一：")]
        public ExcelPropety Name1_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Name1);
        [Display(Name = "金额")]
        public ExcelPropety Fee1_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Fee1);
        [Display(Name = "支付方式一")]
        public ExcelPropety PayMethod1_Excel = ExcelPropety.CreateProperty<Shop>(x => x.PayMethod1);
        [Display(Name = "费用名称二：")]
        public ExcelPropety Name2_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Name2);
        [Display(Name = "金额")]
        public ExcelPropety Fee2_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Fee2);
        [Display(Name = "支付方式二")]
        public ExcelPropety PayMethod2_Excel = ExcelPropety.CreateProperty<Shop>(x => x.PayMethod2);
        [Display(Name = "费用名称三：")]
        public ExcelPropety Name3_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Name3);
        [Display(Name = "金额")]
        public ExcelPropety Fee3_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Fee3);
        [Display(Name = "支付方式三")]
        public ExcelPropety PayMethod3_Excel = ExcelPropety.CreateProperty<Shop>(x => x.PayMethod3);
        [Display(Name = "费用名称四：")]
        public ExcelPropety Name4_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Name4);
        [Display(Name = "金额")]
        public ExcelPropety Fee4_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Fee4);
        [Display(Name = "支付方式四")]
        public ExcelPropety PayMethod4_Excel = ExcelPropety.CreateProperty<Shop>(x => x.PayMethod4);
        [Display(Name = "费用名称五：")]
        public ExcelPropety Name5_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Name5);
        [Display(Name = "金额")]
        public ExcelPropety Fee5_Excel = ExcelPropety.CreateProperty<Shop>(x => x.Fee5);
        [Display(Name = "支付方式五")]
        public ExcelPropety PayMethod5_Excel = ExcelPropety.CreateProperty<Shop>(x => x.PayMethod5);
        //[Display(Name = "微信转账手续费")]
        //public ExcelPropety WXZZFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.WXZZFee);
        //[Display(Name = "现金收支")]
        //public ExcelPropety XjFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.XjFee);
        //[Display(Name = "微信收支")]
        //public ExcelPropety WxFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.WxFee);
        //[Display(Name = "刷卡收支")]
        //public ExcelPropety SkFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.SkFee);
        //[Display(Name = "支付宝收支")]
        //public ExcelPropety ZfbFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.ZfbFee);
        //[Display(Name = "总收支")]
        //public ExcelPropety SumFee_Excel = ExcelPropety.CreateProperty<Shop>(x => x.SumFee);

	    protected override void InitVM()
        {
        }

    }

    public class ShopImportVM : BaseImportVM<ShopTemplateVM, Shop>
    {

    }

}
