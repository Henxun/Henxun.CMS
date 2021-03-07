using System;

namespace Henxun.Cms.ViewModels
{
    public class ManagerListModel
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
        /// 角色名称
        /// </summary>
        public String RoleName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

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
        /// 登录次数
        /// </summary>
        public Int32? LoginCount { get; set; }

        /// <summary>
        /// 最后一次登录IP
        /// </summary>
        public String LoginLastIp { get; set; }

        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime? LoginLastTime { get; set; }


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
