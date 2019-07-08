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
    public partial class ShopCensusSearcher : BaseSearcher
    {
        [Display(Name = "流水日期")]
        public DateTime? Riqi { get; set; }
        [Display(Name = "流水来源")]
        public CensusTypeEnum? Type { get; set; }

        protected override void InitVM()
        {
        }

    }
}
