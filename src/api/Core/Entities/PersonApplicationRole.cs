using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PersonApplicationRole
    {
        public Guid Id { get; set; }
        public string RoleType { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public Guid ApplicationRoleId { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
    }
}
