using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Henxun.Cms.ViewModels
{
    public class ManagerAddOrModifyModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Display(Name = "所属角色")]
        public Int32 RoleId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名")]
        [Required]
        public String UserName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public String Avatar { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [Display(Name = "用户昵称")]
        [Required]
        public String NickName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Display(Name = "手机号码")]
        [Required]
        [Phone(ErrorMessage = "手机号码格式不正确")]
        public String Mobile { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [Display(Name = "邮箱地址")]
        [Required]
        [EmailAddress(ErrorMessage = "邮箱格式不正确")]
        public String Email { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        [Display(Name = "是否锁定")]
        [Required]
        public Boolean IsLock { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [Required]
        public String Remark { get; set; }
    }
}
