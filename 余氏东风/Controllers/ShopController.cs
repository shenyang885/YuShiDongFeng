﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using 余氏东风.ViewModels.ShopVMs;

namespace 余氏东风.Controllers
{
    
    [ActionDescription("财务流水")]
    public partial class ShopController : BaseController
    {
        #region 搜索
        [ActionDescription("搜索")]
        public ActionResult Index()
        {
            var vm = CreateVM<ShopListVM>();
            return PartialView(vm);
        }
        #endregion

        #region 新建
        [ActionDescription("新建")]
        public ActionResult Create()
        {
            var vm = CreateVM<ShopVM>();
            return PartialView(vm);
        }

        [HttpPost]
        [ActionDescription("新建")]
        public ActionResult Create(ShopVM vm)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(vm);
            }
            else
            {
                float[] fee = new float[4];
                fee[vm.Entity.PayMethod1.GetHashCode()] += vm.Entity.Fee1;
                fee[vm.Entity.PayMethod2.GetHashCode()] += vm.Entity.Fee2;
                fee[vm.Entity.PayMethod3.GetHashCode()] += vm.Entity.Fee3;
                fee[vm.Entity.PayMethod4.GetHashCode()] += vm.Entity.Fee4;
                fee[vm.Entity.PayMethod5.GetHashCode()] += vm.Entity.Fee5;
                vm.Entity.XjFee = fee[0];
                vm.Entity.WxFee = fee[1];
                vm.Entity.SkFee = fee[2];
                vm.Entity.ZfbFee = fee[3];
                vm.Entity.WXZZFee = vm.Entity.WxFee * 0.001f;
                vm.Entity.SumFee = vm.Entity.XjFee + vm.Entity.WxFee + vm.Entity.SkFee + vm.Entity.ZfbFee - vm.Entity.WXZZFee;
                vm.DoAdd();
                if (!ModelState.IsValid)
                {
                    vm.DoReInit();
                    return PartialView(vm);
                }
                else
                {
                    return FFResult().CloseDialog().RefreshGrid();
                }
            }
        }
        #endregion

        #region 修改
        [ActionDescription("修改")]
        public ActionResult Edit(Guid id)
        {
            var vm = CreateVM<ShopVM>(id);
            return PartialView(vm);
        }

        [ActionDescription("修改")]
        [HttpPost]
        public ActionResult Edit(ShopVM vm)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(vm);
            }
            else
            {
                float[] fee = new float[5];
                fee[vm.Entity.PayMethod1.GetHashCode()] += vm.Entity.Fee1;
                fee[vm.Entity.PayMethod2.GetHashCode()] += vm.Entity.Fee2;
                fee[vm.Entity.PayMethod3.GetHashCode()] += vm.Entity.Fee3;
                fee[vm.Entity.PayMethod4.GetHashCode()] += vm.Entity.Fee4;
                fee[vm.Entity.PayMethod5.GetHashCode()] += vm.Entity.Fee5;
                vm.Entity.XjFee = fee[0];
                vm.Entity.WxFee = fee[1];
                vm.Entity.SkFee = fee[2];
                vm.Entity.ZfbFee = fee[3];
                vm.Entity.WXZZFee = vm.Entity.WxFee * 0.001f;
                vm.Entity.SumFee = vm.Entity.XjFee + vm.Entity.WxFee + vm.Entity.SkFee + vm.Entity.ZfbFee - vm.Entity.WXZZFee;
                vm.DoEdit();
                if (!ModelState.IsValid)
                {
                    vm.DoReInit();
                    return PartialView(vm);
                }
                else
                {
                    return FFResult().CloseDialog().RefreshGridRow(vm.Entity.ID);
                }
            }
        }
        #endregion

        #region 删除
        [ActionDescription("删除")]
        public ActionResult Delete(Guid id)
        {
            var vm = CreateVM<ShopVM>(id);
            return PartialView(vm);
        }

        [ActionDescription("删除")]
        [HttpPost]
        public ActionResult Delete(Guid id, IFormCollection nouse)
        {
            var vm = CreateVM<ShopVM>(id);
            vm.DoDelete();
            if (!ModelState.IsValid)
            {
                return PartialView(vm);
            }
            else
            {
                return FFResult().CloseDialog().RefreshGrid();
            }
        }
        #endregion

        #region 详细
        [ActionDescription("详细")]
        public ActionResult Details(Guid id)
        {
            var vm = CreateVM<ShopVM>(id);
            return PartialView(vm);
        }
        #endregion

        #region 批量修改
        [HttpPost]
        [ActionDescription("批量修改")]
        public ActionResult BatchEdit(Guid[] IDs)
        {
            var vm = CreateVM<ShopBatchVM>(Ids: IDs);
            return PartialView(vm);
        }

        [HttpPost]
        [ActionDescription("批量修改")]
        public ActionResult DoBatchEdit(ShopBatchVM vm, IFormCollection nouse)
        {
            if (!ModelState.IsValid || !vm.DoBatchEdit())
            {
                return PartialView("BatchEdit",vm);
            }
            else
            {
                return FFResult().RefreshGrid().CloseDialog().Alert("操作成功，共有"+vm.Ids.Length+"条数据被修改");
            }
        }
        #endregion

        #region 批量删除
        [HttpPost]
        [ActionDescription("批量删除")]
        public ActionResult BatchDelete(Guid[] IDs)
        {
            var vm = CreateVM<ShopBatchVM>(Ids: IDs);
            return PartialView(vm);
        }

        [HttpPost]
        [ActionDescription("批量删除")]
        public ActionResult DoBatchDelete(ShopBatchVM vm, IFormCollection nouse)
        {
            if (!ModelState.IsValid || !vm.DoBatchDelete())
            {
                return PartialView("BatchDelete",vm);
            }
            else
            {
                return FFResult().RefreshGrid().CloseDialog().Alert("操作成功，共有"+vm.Ids.Length+"条数据被删除");
            }
        }
        #endregion

        #region 导入
		[ActionDescription("导入")]
        public ActionResult Import()
        {
            var vm = CreateVM<ShopImportVM>();
            return PartialView(vm);
        }

        [HttpPost]
        [ActionDescription("导入")]
        public ActionResult Import(ShopImportVM vm, IFormCollection nouse)
        {
            if (vm.ErrorListVM.EntityList.Count > 0 || !vm.BatchSaveData())
            {
                return PartialView(vm);
            }
            else
            {
                return FFResult().RefreshGrid().CloseDialog().Alert("成功导入 " + vm.EntityList.Count.ToString() + " 行数据");
            }
        }
        #endregion
    }
}
