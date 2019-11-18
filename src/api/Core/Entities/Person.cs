using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public Employee Employee { get; set; }
        public Client Client { get; set; }

        public ICollection<PersonApplicationRole> PersonApplicationRoles { get; set; }
    }
}
