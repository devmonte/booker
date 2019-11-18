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

    }
}
