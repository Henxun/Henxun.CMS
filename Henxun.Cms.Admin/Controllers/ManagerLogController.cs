using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class ManagerLogController : Controller
    {
        private readonly IManagerLogService service;

        public ManagerLogController(IManagerLogService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string key, int page, int limit)
        {
            var data = await service.LoadDataAsync(new ManagerLogRequestModel
            {
                Key = key,
                Page = page,
                Limit = limit
            });
            return new JsonResult(data);
        }
    }
}
