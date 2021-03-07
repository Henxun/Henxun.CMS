namespace Henxun.Cms.ViewModels
{
    public class MenuNavView
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string IconUrl { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool Spread { get; set; } = false;
        /// <summary>
        /// 是否新开窗口
        /// </summary>
        public string Target { get; set; }
    }
}
