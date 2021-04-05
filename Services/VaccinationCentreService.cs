using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;

namespace VaccinationCentres.Services
{
    public class VaccinationCentreService : IVaccinationCentreService
    {
        private readonly VaccinationCentresContext _dbContext;
        private readonly IMapper _mapper;

        public VaccinationCentreService(VaccinationCentresContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public VaccinationCentreDto GetAddressById(int id)
        {
            var vaccinationCentre = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);
            var vaccinationCentreDto = _mapper.Map<VaccinationCentreDto>(vaccinationCentre);

            if (vaccinationCentre is null)
            {
                return null;
            }

            return vaccinationCentreDto;
        }

        public VaccinatorDto GetVaccinatorById(int id)
        {
            var vaccinator = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);
            var vaccinatorDto = _mapper.Map<VaccinatorDto>(vaccinator);

            if (vaccinator is null)
            {
                return null;
            }

            return vaccinatorDto;
        }

        public IEnumerable<VaccinationCentre> GetAll()
        {

            var vaccinationCentres = _dbContext.VaccinationCentres.Where(x => true);
            return vaccinationCentres;
        }


        public void Create(VaccinationCentre vaccinationCentre)
        {
            _dbContext.VaccinationCentres.Add(vaccinationCentre);
            _dbContext.SaveChanges();

        }

    }
}
