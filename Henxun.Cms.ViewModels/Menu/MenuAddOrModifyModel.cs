/****************************************************************
*命名空间：Henxun.Cms.ViewModels.Menu
*文件名：MenuAddOrModifyModel
*唯一标识：5134e785-1da1-44e5-b9af-32c99a958832
*创建人：Administrator
*创建时间：2021/4/1 13:43:16
****************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Henxun.Cms.ViewModels
{
    public class MenuAddOrModifyModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        [Key]
        public Int32 Id { get; set; }

        /// <summary>
        /// 父菜单ID
        /// </summary>
        public Int32 ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        [Required]
        public String Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [Display(Name = "显示名称")]
        [Required]
        public String DisplayName { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [Display(Name = "图标")]
        [MaxLength(128)]
        [Required]
        public String IconUrl { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [Display(Name = "链接")]
        [MaxLength(128)]
        [Required]
        public String LinkUrl { get; set; }

        /// <summary>
        /// 排序数字
        /// </summary>
        [Display(Name = "排序")]
        [Required]
        public Int32? Sort { get; set; }

        /// <summary>
        /// 操作权限（按钮权限时使用）
        /// </summary>z
        [Display(Name = "操作权限")]
        public String Permission { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [Display(Name = "显示")]
        [Required]
        public Boolean IsDisplay { get; set; }

        /// <summary>
        /// 是否系统默认,系统默认不能删除
        /// </summary>
        [Display(Name = "系统默认")]
        [Required]
        public Boolean IsSystem { get; set; }
    }
}
