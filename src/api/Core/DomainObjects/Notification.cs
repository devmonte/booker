using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainObjects
{
    public class Notification
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public string UserMail { get; set; }
        public string UserPhone { get; set; }
    }
}
