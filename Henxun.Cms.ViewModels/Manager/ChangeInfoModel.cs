using System;

namespace Henxun.Cms.ViewModels
{
    public class ChangeInfoModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Int32 Id { get; set; }

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
        /// 备注
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public Int32? ModifyManagerId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
