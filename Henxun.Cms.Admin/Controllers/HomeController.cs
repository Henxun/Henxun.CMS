using Henxun.Cms.Admin.Models;
using Henxun.Cms.Core.Extensions;
using Henxun.Cms.Core.Helper;
using Henxun.Cms.Core.Models;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Henxun.Cms.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IManagerService _managerService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IManagerRoleService _managerRoleService;

        public HomeController(IManagerService managerService, IManagerRoleService managerRoleService, IHttpContextAccessor httpContextAccessor)
        {
            _managerService = managerService;
            _managerRoleService = managerRoleService;
            _httpContextAccessor = httpContextAccessor;
        }



        /// <summary>
        /// 主界面
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Index()
        {
            ViewData["NickName"] = _httpContextAccessor.HttpContext.Session.GetString("NickName");
            ViewData["Avatar"] = _httpContextAccessor.HttpContext.Session.GetString("Avatar");
            var role = _httpContextAccessor.HttpContext.Session.GetInt32("RoleId");
            ViewData["Menus"] = role.HasValue ? _managerRoleService.GetMenusByRoleId(role.Value).GenerateTree(x => x.Id, x => x.ParentId): new List<TreeItem<MenuNavView>>();
            return View();
        }

        /// <summary>
        /// 控制中心
        /// </summary>
        /// <returns></returns>
        public IActionResult Main()
        {
            ViewData["LoginCount"] = User.Claims.FirstOrDefault(x => x.Type == "LoginCount")?.Value;
            ViewData["LoginLastIp"] = User.Claims.FirstOrDefault(x => x.Type == "LoginLastIp")?.Value;
            ViewData["LoginLastTime"] = User.Claims.FirstOrDefault(x => x.Type == "LoginLastTime")?.Value;
            return View();
        }


        public string GetMenu()
        {
            var roleId = HttpContext.Session.GetInt32("RoleId");
            var navViewTree = _managerRoleService.GetMenusByRoleId(roleId.Value).GenerateTree(x => x.Id, x => x.ParentId);
            return JsonHelper.ObjectToJSON(navViewTree);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
