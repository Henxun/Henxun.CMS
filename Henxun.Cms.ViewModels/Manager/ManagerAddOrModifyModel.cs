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
        public Int32 RoleId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public String Avatar { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public String NickName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public String Mobile { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public String Email { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        public Boolean IsLock { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }
    }
}
