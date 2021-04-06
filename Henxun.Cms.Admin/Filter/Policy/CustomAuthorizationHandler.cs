using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henxun.Cms.Admin.Filter.Policy
{
    public class CustomAuthorizationHandler : AuthorizationHandler<CustomAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomAuthorizationRequirement requirement)
        {
            bool wasAuthorize = false;
            switch(requirement.RoleId)
            {
                //超级管理员
                case "1":
                    wasAuthorize = context.User.FindFirst(s => s.Value.Contains("1")) != null;
                    break;
                //系统管理员
                case "2":
                    wasAuthorize = context.User.FindFirst(s => s.Value.Contains("1")) != null;
                    break;
            }

            if(wasAuthorize)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
