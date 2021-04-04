/****************************************************************
*命名空间：Henxun.Cms.ViewModels.Menu
*文件名：MenuListModel
*唯一标识：0130ef78-30eb-4e9b-b5ef-6002cbd2c735
*创建人：Administrator
*创建时间：2021/4/4 12:08:10
****************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Henxun.Cms.ViewModels
{
    public class MenuListModel
    {/// <summary>
	 /// 主键
	 /// </summary>
		[Key]
		public Int32 Id { get; set; }

		/// <summary>
		/// 父菜单ID
		/// </summary>
		[Required]
		[MaxLength(10)]
		public Int32 ParentId { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[Required]
		[MaxLength(32)]
		public String Name { get; set; }

		/// <summary>
		/// 显示名称
		/// </summary>
		[MaxLength(128)]
		public String DisplayName { get; set; }

		/// <summary>
		/// 图标地址
		/// </summary>
		[MaxLength(128)]
		public String IconUrl { get; set; }

		/// <summary>
		/// 链接地址
		/// </summary>
		[MaxLength(128)]
		public String LinkUrl { get; set; }

		/// <summary>
		/// 排序数字
		/// </summary>
		[MaxLength(10)]
		public Int32? Sort { get; set; }

		/// <summary>
		/// 操作权限（按钮权限时使用）
		/// </summary>
		[MaxLength(256)]
		public String Permission { get; set; }

		/// <summary>
		/// 是否显示
		/// </summary>
		[Required]
		[MaxLength(1)]
		public Boolean IsDisplay { get; set; }

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
	}
}
