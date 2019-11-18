using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class BookerDbContext : DbContext
    {
        public BookerDbContext(DbContextOptions<BookerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Salon> Salons { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
