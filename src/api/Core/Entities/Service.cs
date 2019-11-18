using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Service
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int Duration { get; set; }
        public string  Type { get; set; }

        public Guid SalonId { get; set; }
        public Salon Salon { get; set; }

        public ICollection<EmployeeService> EmployeeServices { get; set; }

        public ICollection<Visit> Visits { get; set; }
    }
}
