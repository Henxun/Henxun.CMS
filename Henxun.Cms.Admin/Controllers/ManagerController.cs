using AutoMapper;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService managerService;
        private readonly IManagerRoleService managerRoleService;
        private readonly IMapper mapper;

        private IEnumerable<SelectListItem> Roles => managerRoleService.GetListByCondition(new ManagerRoleRequestModel()).Select(s=>new SelectListItem { Text = s.RoleName, Value = s.Id.ToString()});

        public ManagerController(IManagerService managerService,IManagerRoleService managerRoleService, IMapper mapper)
        {
            this.managerService = managerService;
            this.managerRoleService = managerRoleService;
            this.mapper = mapper;
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

        public IActionResult Add()
        {
            ViewBag.RoleList = Roles;
            return View();
        }

        public async Task<IActionResult> Post(ManagerAddOrModifyModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await managerService.AddOrModifyAsync(model);
                return new JsonResult(result);
            }
            return View(model);
        }

        public IActionResult Edit(string data)
        {
            string json = System.Web.HttpUtility.HtmlDecode(data);
            var model = JsonConvert.DeserializeObject<ManagerAddOrModifyModel>(json);
            ViewBag.RoleList = Roles;
            return View(model);
        }

        public async Task<IActionResult> Edited(ManagerAddOrModifyModel model)
        {
            if(ModelState.IsValid)
            {
                var res = await managerService.AddOrModifyAsync(model);
                return new JsonResult(res);
            }
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

        public IActionResult RoleManagement()
        {
            return View();
        }
    }
}
