using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.Extensions.Logging;

namespace Infrastructure
{
    public class DbSeeder : IDbSeeder
    {
        private readonly ILogger<DbSeeder> _logger;
        private readonly BookerDbContext _context;

        public DbSeeder(ILogger<DbSeeder> logger, BookerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Salons.Any())
            {

                _context.Salons.Add(new Salon
                {
                    Name = "Example Beauty Studio",
                    Address = "ul. Focha 13",
                    City = "Bydgoszcz"
                });
            }
            if (!_context.Visits.Any())
            {
                _context.Visits.Add(new Visit
                {
                    DateTime = new DateTime(2019, 11, 30, 10, 0, 0, DateTimeKind.Utc),
                    Duration = 30,
                });
            }
            _context.SaveChanges();
        }
    }
}
