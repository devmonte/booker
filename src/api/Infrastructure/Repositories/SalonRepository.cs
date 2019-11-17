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

        public SalonRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IList<Salon> GetAll()
        {
            var domainSalon = _mapper.Map<Salon>(new Core.Entities.Salon { Name = "test" });

            return new List<Salon> { domainSalon };
        }
    }
}
