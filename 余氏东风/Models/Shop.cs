using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WalkingTec.Mvvm.Core;

namespace 余氏东风.Models
{


        public enum PayTypeEnum
        {
            [Display(Name = "现金")]
            XJ,
            [Display(Name = "微信")]
            WX,
            [Display(Name = "刷卡")]
            SK,
            [Display(Name = "支付宝")]
            ZFB
        }
        public enum TypeEnum
        {
            [Display(Name = "店铺")]
            XJ,
            [Display(Name = "三轮车")]
            WX,
            [Display(Name = "送货员")]
            SK
        }
    public class Shop : PersistPoco
{       /// <summary>
        /// 流水日期
        /// </summary>
        [Display(Name = "流水日期")]
        [Required(ErrorMessage = "{0}是必填项")]
            //[RegularExpression("^[0-9]{3,3}$", ErrorMessage = "{0}必须是3位数字")]
            //[StringLength(3)]
            public DateTime Riqi { get; set; }
        /// <summary>
        /// 流水来源
        /// </summary>
        [Display(Name = "流水来源")]
            [Required(ErrorMessage = "{0}是必填项")]
            //[RegularExpression("^[0-9]{3,3}$", ErrorMessage = "{0}必须是3位数字")]
            //[StringLength(3)]
             public TypeEnum Type { get; set; }
        /// <summary>
        /// 付款人
        /// </summary>
        [Display(Name = "付款人")]
            [Required(ErrorMessage = "{0}是必填项")]
            public string FkRenYuan { get; set; }
        /// <summary>
        /// 收款人
        /// </summary>
        [Display(Name = "收款人")]
            [Required(ErrorMessage = "{0}是必填项")]
            public string SkRenYuan { get; set; }
        /// <summary>
        /// 费用名称一
        /// </summary>
        [Display(Name = "费用名称")]
                public string Name1 { get; set; }
        /// <summary>
        /// 金额一
        /// </summary>
        [Display(Name = "金额")]
            public float Fee1 { get; set; }
        /// <summary>
        /// 支付方式一
        /// </summary>
        [Display(Name = "支付方式")]
            public PayTypeEnum PayMethod1 { get; set; }
        /// <summary>
        /// 费用名称二
        /// </summary>
        [Display(Name = "费用名称")]
            public string Name2 { get; set; }
        /// <summary>
        /// 金额二
        /// </summary>
        [Display(Name = "金额")]
            public float Fee2 { get; set; }
        /// <summary>
        /// 支付方式二
        /// </summary>
        [Display(Name = "支付方式")]
            public PayTypeEnum PayMethod2 { get; set; }
        /// <summary>
        /// 费用名称三
        /// </summary>
        [Display(Name = "费用名称")]
            public string Name3 { get; set; }
        /// <summary>
        /// 金额三
        /// </summary>
        [Display(Name = "金额")]
            public float Fee3 { get; set; }
        /// <summary>
        /// 支付方式三
        /// </summary>
        [Display(Name = "支付方式")]
            public PayTypeEnum PayMethod3 { get; set; }
        /// <summary>
        /// 费用名称四
        /// </summary>
        [Display(Name = "费用名称")]
            public string Name4 { get; set; }
        /// <summary>
        /// 金额四
        /// </summary>
        [Display(Name = "金额")]
            public float Fee4 { get; set; }
        /// <summary>
        /// 支付方式四
        /// </summary>
        [Display(Name = "支付方式")]
            public PayTypeEnum PayMethod4 { get; set; }
        /// <summary>
        /// 费用名称五
        /// </summary>
        [Display(Name = "费用名称")]
            public string Name5 { get; set; }
        /// <summary>
        /// 金额五
        /// </summary>
        [Display(Name = "金额")]
            public float Fee5 { get; set; }
        /// <summary>
        /// 支付方式五
        /// </summary>
        [Display(Name = "支付方式")]
            public PayTypeEnum PayMethod5 { get; set; }
        /// <summary>
        /// 微信转账手续费
        /// </summary>
        [Display(Name = "微信转账手续费")]
            public float WXZZFee { get; set; }
        /// <summary>
        /// 现金收支
        /// </summary>
        [Display(Name = "现金收支")]
            public float XjFee { get; set; }
        /// <summary>
        /// 微信收支
        /// </summary>
        [Display(Name = "微信收支")]
            public float WxFee { get; set; }
        /// <summary>
        /// 刷卡收支
        /// </summary>
        [Display(Name = "刷卡收支")]
            public float SkFee { get; set; }
        /// <summary>
        /// 支付宝收支
        /// </summary>
        [Display(Name = "支付宝收支")]
            public float ZfbFee { get; set; }
        /// <summary>
        /// 总收支
        /// </summary>
        [Display(Name = "总收支")]
            public float SumFee { get; set; }
        public Shop()
        {
            PayMethod1 = PayTypeEnum.XJ;
            PayMethod2 = PayTypeEnum.XJ;
            PayMethod3 = PayTypeEnum.XJ;
            PayMethod4 = PayTypeEnum.XJ;
            PayMethod5 = PayTypeEnum.XJ;
        }

    }
    

}
