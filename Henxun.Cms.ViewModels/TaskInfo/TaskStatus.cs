using System.ComponentModel;

namespace Henxun.Cms.ViewModels
{
    public enum TaskInfoStatus:byte
    {
        [Description("执行中")]
        Running,
        [Description("已完成")]
        Completed,
        [Description("已停止")]
        Stopped,
        [Description("系统停止")]
        SystemStopped,
    }
}
