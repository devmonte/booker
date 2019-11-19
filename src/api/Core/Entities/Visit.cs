using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Visit
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public bool Reminded { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid? ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
