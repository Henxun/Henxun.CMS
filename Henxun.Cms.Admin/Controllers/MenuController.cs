using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Get(string key, int page = 1, int limit = 10)
        {
            var data = await menuService.LoadDataAsync(new MenuRequestModel { Key = key, Page = page, Limit = limit });
            if(data.count > 0)
            {
                return new JsonResult(new
                {
                    code = "0",
                    msg = "",
                    count = data.count,
                    data = data.data
                });
            }
            else
            {
                return new JsonResult(new
                {
                    code = "204",
                    msg = "未查询到数据"
                });
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Post(MenuAddOrModifyModel model)
        {
            var res = await menuService.AddOrModifyAsync(model);
            if(res.ResultCode == ResultCodeAddMsgKeys.CommonObjectSuccessCode)
            {
                return new JsonResult(res);
            }
            return View(model);
        }

        public IActionResult Edit(string data)
        {
            string json = System.Web.HttpUtility.HtmlDecode(data);
            var model = JsonConvert.DeserializeObject<MenuAddOrModifyModel>(json);
            return View(model);
        }

        public async Task<IActionResult> Delete(int[] ids)
        {
            var res = await menuService.DeleteAsync(ids);
            return new JsonResult(res);
        }
    }
}
