using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Reminder.Entities
{
    public class Visit
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public bool Reminded { get; set; }
    }
}
