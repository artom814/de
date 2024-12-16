using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zayavochka
{
    internal class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public string Crash { get; set; }
        public string TechnicType { get; set; }
        public int MasterId { get; set; }
        public int StatusId { get; set; }

        public Task(int taskid, int masterid, int statusid)
        {
            TaskId = taskid;
            MasterId = masterid;
            StatusId = statusid;
            Description = string.Empty;
            Crash = string.Empty;
            TechnicType = string.Empty;
            StatusId = statusId;
        }
    }
}
