using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace Henxun.Cms.Admin.Controllers
{
    public class FileController : Controller
    {
        private readonly IHostingEnvironment hostingEnv;

        public FileController(IHostingEnvironment hostingEnv)
        {
            this.hostingEnv = hostingEnv;
        }


        /// <summary>
        /// 图片上传功能
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UploadImage()
        {
            #region 文件上传
            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName))
            {
                long size = 0;
                string tempname = "";
                var filename = ContentDispositionHeaderValue
                                .Parse(imgFile.ContentDisposition)
                                .FileName
                                .Trim('"');
                var extname = filename.Substring(filename.LastIndexOf("."), filename.Length - filename.LastIndexOf("."));
                #region 判断后缀
                //if (!extname.ToLower().Contains("jpg") && !extname.ToLower().Contains("png") && !extname.ToLower().Contains("gif"))
                //{
                //    return Json(new { code = 1, msg = "只允许上传jpg,png,gif格式的图片.", });
                //}
                #endregion
                #region 判断大小
                long mb = imgFile.Length / 1024 / 1024; // MB
                if (mb > 1)
                {
                    return Json(new { code = 1, msg = "只允许上传小于 1MB 的图片.", });
                }
                #endregion
                var filename1 =DateTime.Now.ToString("yyyyMMddHHmmssfff")+new Random().Next(1000,9999)+ extname;
                tempname = filename1;
                var path = hostingEnv.WebRootPath;
                string dir = DateTime.Now.ToString("yyyyMMdd");
                if (!Directory.Exists(hostingEnv.WebRootPath + $@"\upload\{dir}"))
                {
                    Directory.CreateDirectory(hostingEnv.WebRootPath + $@"\upload\{dir}");
                }
                filename = hostingEnv.WebRootPath + $@"\upload\{dir}\{filename1}";
                size += imgFile.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }
                return Json(new { code = 0, msg = "上传成功", data = new { src = $"/upload/{dir}/{filename1}", title = "图片标题" } });
            }
            return Json(new { code = 1, msg = "上传失败", });
            #endregion
        }
    }
}