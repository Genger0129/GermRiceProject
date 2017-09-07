using NFine.Application.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFine.Code;
using NFine.Code.WeChat;

namespace NFine.Web.Areas.Province.Controllers
{
    public class ProvinceController : ControllerBase
    {
        private CommonApp<NFine.Data.Province> provinceApp = new CommonApp<NFine.Data.Province>();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson()
        {
            var data = provinceApp.IQueryable().ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(Guid? keyValue)
        {
            var data = provinceApp.FindEntity(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(NFine.Data.Province entity, Guid? keyValue)
        {
            if (keyValue != null)
            {
                entity.ProvinceId = (Guid)keyValue;
                provinceApp.Update(entity);
            }
            else
            {
                entity.ProvinceId = Guid.NewGuid();
                provinceApp.Insert(entity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(Guid? keyValue)
        {
            if(keyValue == null)
                return Error("未选中任何项。");
            provinceApp.Delete(t => t.ProvinceId == keyValue);
            return Success("删除成功。");
        }
        

    }
}
