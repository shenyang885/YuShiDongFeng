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
    public partial class ShopSearcher : BaseSearcher
    {
        [Display(Name = "流水日期")]
        public DateTime? Riqi { get; set; }
        [Display(Name = "付款人")]
        public String FkRenYuan { get; set; }
        [Display(Name = "收款人")]
        public String SkRenYuan { get; set; }

        protected override void InitVM()
        {
        }

    }
}
