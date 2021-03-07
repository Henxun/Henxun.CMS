namespace Henxun.Cms.ViewModels
{
    public class ChangePasswordModel
    {
        /// <summary>
        /// 当前管理员主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 旧密码
        /// </summary>
        public string OldPassword { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
        /// <summary>
        /// 重复密码
        /// </summary>
        public string NewPasswordRe { get; set; }
    }
}
