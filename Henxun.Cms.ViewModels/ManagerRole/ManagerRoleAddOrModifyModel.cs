using System;
using System.ComponentModel.DataAnnotations;

namespace Henxun.Cms.ViewModels
{
    public class ManagerRoleAddOrModifyModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Display(Name = "角色名称")]
        [Required]
        public String RoleName { get; set; }

        /// <summary>
        /// 角色类型1超管2系管
        /// </summary>
        [Display(Name = "角色类型")]
        [Required]
        public Int32 RoleType { get; set; }

        /// <summary>
        /// 是否系统默认
        /// </summary>
        [Display(Name = "系统默认")]
        [Required]
        public Boolean IsSystem { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [Required]
        public String Remark { get; set; }
        /// <summary>
        /// 菜单列表
        /// </summary>
        [Display(Name = "菜单列表")]
        [Required]
        public int[] MenuIds { get; set; }
    }
}
