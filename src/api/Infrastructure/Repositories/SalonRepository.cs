using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.DomainObjects;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class SalonRepository : ISalonsRepository
    {
        private readonly IMapper _mapper;
        private readonly BookerDbContext _dbContext;

        public SalonRepository(IMapper mapper, BookerDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public IList<Salon> GetAll()
        {
            var domainSalons = _mapper.Map<List<Salon>>(_dbContext.Salons.ToList());

            return domainSalons;
        }
    }
}
