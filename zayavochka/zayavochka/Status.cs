using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zayavochka
{
    internal class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }

        public Status(int statusid)
        {
            StatusId = statusid;
            StatusName = string.Empty;
            StatusDescription = string.Empty;
        }
    }
}
