using FluentValidation;
using Henxun.Cms.ViewModels;

namespace Henxun.Cms.Admin.Validations
{
    public class LoginModelValidation : AbstractValidator<LoginModel>
    {
        public LoginModelValidation()
        {
            CascadeMode = CascadeMode.Stop;
            RuleFor(x => x.UserName).NotEmpty().Length(4, 32).WithMessage("用户名不能为空且长度必须符合规则");
            RuleFor(x => x.Password).NotEmpty().Length(4, 32).WithMessage("密码不能为空且长度必须符合规则");
            RuleFor(x => x.CaptchaCode).NotEmpty().Length(4).WithMessage("请正确输入四位验证码");

        }
    }
}
