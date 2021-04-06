using Microsoft.AspNetCore.Authorization;

namespace Henxun.Cms.Admin.Filter.Policy
{
    public class CustomAuthorizationRequirement: IAuthorizationRequirement
    {
        public CustomAuthorizationRequirement(string roleId)
        {
            RoleId = roleId;
        }
        public string RoleId { get; }
    }
}
