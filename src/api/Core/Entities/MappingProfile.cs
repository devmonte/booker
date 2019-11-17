using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Core.Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Salon, DomainObjects.Salon>();
        }
    }
}
