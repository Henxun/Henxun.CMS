/****************************************************************
*命名空间：Henxun.Cms.ViewModels.ManagerRole
*文件名：ManagerRoleListModel
*唯一标识：954b720f-5aa3-4050-90ca-8d7cb7ab7dd2
*创建人：Administrator
*创建时间：2021/4/1 13:42:33
****************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Henxun.Cms.ViewModels
{
    public class ManagerRoleListModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        [Key]
        public Int32 Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [MaxLength(64)]
        public String RoleName { get; set; }

        /// <summary>
        /// 角色类型1超管2系管
        /// </summary>
        [Required]
        [MaxLength(10)]
        public Int32 RoleType { get; set; }

        /// <summary>
        /// 是否系统默认
        /// </summary>
		[Required]
        [MaxLength(1)]
        public Boolean IsSystem { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
		[Required]
        [MaxLength(10)]
        public Int32 AddManagerId { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
		[Required]
        [MaxLength(23)]
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
		[MaxLength(128)]
        public String Remark { get; set; }

        /// <summary>
        /// 菜单ID数组  
        /// </summary>
        public virtual int[] MenuIds { get; set; }
    }
}
