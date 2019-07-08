using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WalkingTec.Mvvm.Core;

namespace 余氏东风.Models
{
    public enum CensusTypeEnum
    {
        [Display(Name = "全部")]
        QB,
        [Display(Name = "店铺")]
        XJ,
        [Display(Name = "三轮车")]
        WX,
        [Display(Name = "送货员")]
        SK
    }
    public class ShopCensus : PersistPoco
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
             public CensusTypeEnum Type { get; set; }
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

    }
    

}
