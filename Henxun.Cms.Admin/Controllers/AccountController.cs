﻿using FluentValidation.Results;
using Henxun.Cms.Admin.Validations;
using Henxun.Cms.Core.Extensions;
using Henxun.Cms.Core.Helper;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly string CaptchaCodeSessionName = "CaptchaCode";
        private readonly string ManagerSignInErrorTimes = "ManagerSignInErrorTimes";
        private readonly int MaxErrorTimes = 3;
        private readonly IManagerService _service;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(IManagerService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCaptchaImage()
        {
            string captchaCode = CaptchaHelper.GenerateCaptchaCode();
            var result = CaptchaHelper.GetImage(116, 36, captchaCode);
            HttpContext.Session.SetString(CaptchaCodeSessionName, captchaCode);
            return new FileStreamResult(new MemoryStream(result.CaptchaByteData), "image/png");
        }

        private bool ValidateCaptchaCode(string userInputCaptcha)
        {
            var isValid = userInputCaptcha.Equals(HttpContext.Session.GetString(CaptchaCodeSessionName), StringComparison.OrdinalIgnoreCase);
            HttpContext.Session.Remove(CaptchaCodeSessionName);
            return isValid;
        }
        [HttpPost,Route("Account/SignIn")]
        public async Task<string> SignInAsync(LoginModel model)
        {
            BaseResult result = new BaseResult();
            #region 判断验证码
            if (!ValidateCaptchaCode(model.CaptchaCode))
            {
                result.ResultCode = ResultCodeAddMsgKeys.SignInCaptchaCodeErrorCode;
                result.ResultMsg = ResultCodeAddMsgKeys.SignInCaptchaCodeErrorMsg;
                return JsonHelper.ObjectToJSON(result);
            }
            #endregion
            #region 判断错误次数
            var ErrorTimes = HttpContext.Session.GetInt32(ManagerSignInErrorTimes);
            if (ErrorTimes == null)
            {
                HttpContext.Session.SetInt32(ManagerSignInErrorTimes, 1);
                ErrorTimes = 1;
            }
            else
            {
                HttpContext.Session.SetInt32(ManagerSignInErrorTimes, ErrorTimes.Value + 1);
            }
            if (ErrorTimes > MaxErrorTimes)
            {
                result.ResultCode = ResultCodeAddMsgKeys.SignInErrorTimesOverTimesCode;
                result.ResultMsg = ResultCodeAddMsgKeys.SignInErrorTimesOverTimesMsg;
                return JsonHelper.ObjectToJSON(result);
            }
            #endregion
            #region 再次属性判断
            LoginModelValidation validation = new LoginModelValidation();
            ValidationResult results = validation.Validate(model);
            if (!results.IsValid)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = results.ToString("||");
            }
            #endregion

            model.Ip = HttpContext.GetClientUserIp();
            var manager = await _service.SignInAsync(model);
            if (manager == null)
            {
                result.ResultCode = ResultCodeAddMsgKeys.SignInPasswordOrUserNameErrorCode;
                result.ResultMsg = ResultCodeAddMsgKeys.SignInPasswordOrUserNameErrorMsg;
            }
            else if (manager.IsLock)
            {
                result.ResultCode = ResultCodeAddMsgKeys.SignInUserLockedCode;
                result.ResultMsg = ResultCodeAddMsgKeys.SignInUserLockedMsg;
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, manager.UserName),
                    new Claim(ClaimTypes.Role, manager.RoleId.ToString()),

                    new Claim("Id",manager.Id.ToString()),
                    new Claim("NickName",manager.NickName),
                    new Claim("LoginCount",manager.LoginCount.ToString()),
                    new Claim("LoginLastIp",manager.LoginLastIp),
                    new Claim("LoginLastTime",manager.LoginLastTime?.ToString("yyyy-MM-dd HH:mm:ss")),
                };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                _httpContextAccessor.HttpContext.Session.SetInt32("Id", manager.Id);
                _httpContextAccessor.HttpContext.Session.SetInt32("RoleId", manager.RoleId);
                _httpContextAccessor.HttpContext.Session.SetString("NickName", manager.NickName ?? "匿名");
                _httpContextAccessor.HttpContext.Session.SetString("Email", manager.Email ?? "");
                _httpContextAccessor.HttpContext.Session.SetString("Avatar", manager.Avatar ?? "/images/userface1.jpg");
                _httpContextAccessor.HttpContext.Session.SetString("Mobile", manager.Mobile ?? "");
            }
            return JsonHelper.ObjectToJSON(result);
        }

        [HttpGet, Route("Account/SignOut")]
        public async Task<IActionResult> SignOutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [HttpPost,Route("Account/LogIn")]
        public IActionResult LogIn([FromBody]LoginModel model)
        {
            if(model.UserName == "admin" && model.Password == "111111")
            {
                return new OkResult();
            }
            return new ObjectResult("失败");
        }
    }
}
