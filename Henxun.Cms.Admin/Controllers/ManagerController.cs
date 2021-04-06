using AutoMapper;
using Henxun.Cms.Core.Helper;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    [Authorize(Roles = "1")]
    public class ManagerController : Controller
    {
        private readonly IManagerService managerService;
        private readonly IManagerRoleService managerRoleService;
        private readonly IHttpContextAccessor httpContextAccessor;

        private IEnumerable<SelectListItem> Roles => managerRoleService.GetListByCondition(new ManagerRoleRequestModel()).Select(s=>new SelectListItem { Text = s.RoleName, Value = s.Id.ToString()});

        public ManagerController(IManagerService managerService,IManagerRoleService managerRoleService,IHttpContextAccessor httpContextAccessor)
        {
            this.managerService = managerService;
            this.managerRoleService = managerRoleService;
            this.httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Get(string key,int page = 1,int limit = 10)
        {
            var data = await managerService.LoadDataAsync(new ViewModels.ManagerRequestModel() { Key = key, Page = page, Limit = limit});
            if (data.code == 200)
                return new JsonResult(new
                {
                    code = "0",
                    msg = "",
                    count = data.count,
                    data = data.data
                });
            else
                return new JsonResult(new
                {
                    code = "-1",
                    msg = "失败",
                });
        }

        [Authorize(Roles = "1")]
        public IActionResult Add()
        {
            ViewBag.RoleList = Roles;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(ManagerAddOrModifyModel model)
        {
            var result = await managerService.AddOrModifyAsync(model);
            return new JsonResult(result);
        }

        public IActionResult Edit(string data)
        {
            string json = System.Web.HttpUtility.HtmlDecode(data);
            var model = JsonConvert.DeserializeObject<ManagerAddOrModifyModel>(json);
            ViewBag.RoleList = Roles;
            return View(model);
        }

        public async Task<IActionResult> Delete(int[] ids)
        {
            var res = await managerService.DeleteIdsAsync(ids);
            return new JsonResult(res);
        }

        public async Task<IActionResult> ChangeLockStatus(int id, bool status)
        {
            var res = await managerService.ChangeLockStatusAsync(new ChangeStatusModel { Id= id,Status = status});
            return new JsonResult(res);
        }

        public IActionResult ChangePassword()
        {
            ViewData["NickName"] = User.Claims.FirstOrDefault(x => x.Type == "NickName")?.Value;
            ViewData["Id"] = User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Manager/ChangePassword")]
        public async Task<string> ChangePasswordAsync([FromForm] ChangePasswordModel item)
        {
            var result = new BaseResult();
            if (!ModelState.IsValid)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;
            }
            else
            {
                result = await managerService.ChangePasswordAsync(item);
            }
            return JsonHelper.ObjectToJSON(result);
        }

        public async Task<IActionResult> Detail()
        {
            var id = User.FindFirst("Id");
            if(null == id)
            {
                return RedirectToAction("SignOut", "Account");
            }
            var model = await managerService.GetManagerContainRoleNameByIdAsync(int.Parse(id.Value));
            if(null == model)
            {
                return RedirectToAction("SignOut", "Account");
            }
            model.Avatar = model.Avatar ?? "/images/userface1.jpg";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Manager/ManagerInfo")]
        public async Task<string> ManagerInfoAsync([FromForm] ChangeInfoModel item)
        {

            var result = new BaseResult();
            if (ModelState.IsValid)
            {
                item.ModifyManagerId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                item.ModifyTime = DateTime.Now;
                result = await managerService.UpdateManagerInfoAsync(item);
                httpContextAccessor.HttpContext.Session.SetString("NickName", item.NickName ?? "匿名");
                httpContextAccessor.HttpContext.Session.SetString("Email", item.Email ?? "");
                httpContextAccessor.HttpContext.Session.SetString("Avatar", item.Avatar ?? "/images/userface1.jpg");
                httpContextAccessor.HttpContext.Session.SetString("Mobile", item.Mobile ?? "");
            }
            else
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;
            }

            return JsonHelper.ObjectToJSON(result);
        }
    }
}
