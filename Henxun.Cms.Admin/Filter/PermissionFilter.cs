using Henxun.Cms.IServices;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PermissionFilter : Attribute,IAsyncAuthorizationFilter
    {
        private readonly IManagerService _managerService;

        public PermissionFilter(IManagerService managerService)
        {
            _managerService = managerService;
        }

        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var identity = context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"];

            throw new NotImplementedException();
        }
    }
}
