/****************************************************************
*命名空间：Henxun.Cms.ViewModels.Menu
*文件名：MenuAddOrModifyModel
*唯一标识：5134e785-1da1-44e5-b9af-32c99a958832
*创建人：Administrator
*创建时间：2021/4/1 13:43:16
****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henxun.Cms.ViewModels
{
    public class MenuAddOrModifyModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// 父菜单ID
        /// </summary>
        public Int32 ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public String DisplayName { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        public String IconUrl { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public String LinkUrl { get; set; }

        /// <summary>
        /// 排序数字
        /// </summary>
        public Int32? Sort { get; set; }

        /// <summary>
        /// 操作权限（按钮权限时使用）
        /// </summary>
        public String Permission { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public Boolean IsDisplay { get; set; }

        /// <summary>
        /// 是否系统默认,系统默认不能删除
        /// </summary>
        public Boolean IsSystem { get; set; }
    }
}
