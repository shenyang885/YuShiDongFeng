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
    public partial class ShopCensusBatchVM : BaseBatchVM<ShopCensus, ShopCensus_BatchEdit>
    {
        public ShopCensusBatchVM()
        {
            ListVM = new ShopCensusListVM();
            LinkedVM = new ShopCensus_BatchEdit();
        }

        protected override bool CheckIfCanDelete(Guid id, out string errorMessage)
        {
            errorMessage = null;
			return true;
        }
    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class ShopCensus_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
