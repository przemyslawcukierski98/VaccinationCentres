using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;

namespace VaccinationCentres.Mapping
{
    public class VaccinationCentresMappingProfile : Profile
    {
        public VaccinationCentresMappingProfile()
        {
            CreateMap<VaccinationCentre, VaccinationCentreDto>();
        }
    }
}
