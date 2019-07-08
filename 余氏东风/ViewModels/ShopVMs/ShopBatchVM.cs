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
    public partial class ShopBatchVM : BaseBatchVM<Shop, Shop_BatchEdit>
    {
        public ShopBatchVM()
        {
            ListVM = new ShopListVM();
            LinkedVM = new Shop_BatchEdit();
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
    public class Shop_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
