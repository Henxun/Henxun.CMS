using Henxun.Cms.Admin.Validations;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class ManagerRoleController : Controller
    {
        private readonly IManagerRoleService managerRoleService;
        private readonly IMenuService menuService;
        private readonly IHttpContextAccessor httpContextAccessor;

        private IEnumerable<MenuNavView> Menus { get; set; }
        public ManagerRoleController(IManagerRoleService managerRoleService, IMenuService menuService, IHttpContextAccessor httpContextAccessor)
        {
            this.managerRoleService = managerRoleService;
            this.menuService = menuService;
            this.httpContextAccessor = httpContextAccessor;
            var roleId = httpContextAccessor.HttpContext.Session.GetInt32("RoleId");
            Menus = roleId.HasValue ? managerRoleService.GetMenusByRoleId(roleId.Value): new List<MenuNavView>();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get(string key, int page = 1, int limit = 10)
        {
            var td = managerRoleService.LoadData(new ManagerRoleRequestModel
            {
                Key = key,
                Page = page,
                Limit = limit
            });
            if (td.count > 0)
                return new JsonResult(new
                {
                    code = "0",
                    msg = "",
                    count = td.count,
                    data = td.data
                });
            else
                return new JsonResult(new
                {
                    code = "204",
                    msg = "未查询到数据",
                });
        }

        public IActionResult Add()
        {
            ViewBag.Menus = Menus;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]ManagerRoleAddOrModifyModel model)
        {
            var result = new BaseResult();
            var validation = new ManagerRoleValidation();
            var validateResult = await validation.ValidateAsync(model);
            if(validateResult.IsValid)
            {
                result = managerRoleService.AddOrModify(model);
            }
            else
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;
            }
            return new JsonResult(result);
        }

        public IActionResult Edit(string data)
        {
            ViewBag.Menus = menuService.GetListByCondition(new MenuRequestModel() { 
                Condition = " IsDisplay=1"
            });
            string json = System.Web.HttpUtility.HtmlDecode(data);
            var model = JsonConvert.DeserializeObject<ManagerRoleAddOrModifyModel>(json);
            model.MenuIds = managerRoleService.GetMenusByRoleId(model.Id).Select(s => s.Id).ToArray();
            return View(model);
        }

        public async Task<IActionResult> Delete(int[] ids)
        {
            var res = await managerRoleService.DeleteIdsAsync(ids);
            return new JsonResult(res);
        }
    }
}
