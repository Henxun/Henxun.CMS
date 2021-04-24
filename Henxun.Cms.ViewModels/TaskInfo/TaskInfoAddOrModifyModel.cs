/****************************************************************
*命名空间：Henxun.Cms.ViewModels.TaskInfo
*文件名：TaskInfoAddOrModifyModel
*唯一标识：effda1c3-ab2c-4e78-be72-54a0647595d9
*创建人：Administrator
*创建时间：2021/4/10 12:44:09
****************************************************************/
using System;

namespace Henxun.Cms.ViewModels
{
    public class TaskInfoAddOrModifyModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Group { get; set; }
        public String Description { get; set; }
        public String Assembly { get; set; }
        public String ClassName { get; set; }
        public String Cron { get; set; }
        public DateTime? AddTime { get; set; }
        public int AddManagerId { get; set; }
    }
}
