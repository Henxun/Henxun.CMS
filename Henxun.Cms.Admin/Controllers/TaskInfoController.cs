using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class TaskInfoController : Controller
    {
        private readonly ITaskInfoService service;

        public TaskInfoController(ITaskInfoService service)
        {
            this.service = service;
        }
        // GET: TaskInfoController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string key, int page, int limit)
        {
            var td = await service.LoadDataAsync(new TaskRequestModel
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

        [HttpGet]
        public IActionResult AddOrModify()
        {
            return View();

        }

        // GET: TaskInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskInfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskInfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
