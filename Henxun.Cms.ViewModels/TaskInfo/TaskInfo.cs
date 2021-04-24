/****************************************************************
*命名空间：Henxun.Cms.ViewModels.TaskInfo
*文件名：TaskInfo
*唯一标识：ce62f905-8d30-4034-a658-a2e2017b923c
*创建人：Administrator
*创建时间：2021/4/10 12:43:04
****************************************************************/
using System;

namespace Henxun.Cms.ViewModels
{
    public class TaskInfo
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String Group { get; set; }

        public String Description { get; set; }

        public String Assembly { get; set; }

        public String ClassName { get; set; }

        public Int32 Status { get; set; }

        public String Cron { get; set; }
    }
}
