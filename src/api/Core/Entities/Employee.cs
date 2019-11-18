using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        public Guid SalonId { get; set; }
        public Salon Salon { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public ICollection<Visit> Visits { get; set; }
        public ICollection<EmployeeService> EmployeeServices { get; set; }

    }
}
