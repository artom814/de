using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zayavochka
{
    internal class Master
    {
        public int MasterId { get; set; }
        public string MasterName { get; set; }
        public string MasterSecondName { get; set; }
        public string MasterEmail { get; set; }
        public string MasterPassword { get; set; }
        public string MasterPhoneNumber { get; set; }

        public Master(int masterid)
        {
            MasterId = masterid;
            MasterName = string.Empty;
            MasterSecondName = string.Empty;
            MasterEmail = string.Empty;
            MasterPassword = string.Empty;
            MasterPhoneNumber = string.Empty;            
        }
    }
}
