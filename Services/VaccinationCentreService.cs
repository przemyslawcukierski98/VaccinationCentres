using AutoMapper;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<VaccinationCentreService> _logger;

        public VaccinationCentreService(VaccinationCentresContext dbContext, IMapper mapper, ILogger<VaccinationCentreService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public VaccinationCentreDto GetAddressById(int id)
        {
            _logger.LogInformation($"Vaccination center address with id: {id} GET action invoked");
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
            _logger.LogInformation($"Vaccinator with id: {id} GET action invoked");
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
            _logger.LogInformation("View information of all vaccination centers");

            var vaccinationCentres = _dbContext.VaccinationCentres.Where(x => true);
            return vaccinationCentres;
        }

        public int Create(VaccinationCentre vaccinationCentre)
        {
            _logger.LogInformation($"Vaccination centre with id: {vaccinationCentre.Id} is created");
            _dbContext.VaccinationCentres.Add(vaccinationCentre);
            _dbContext.SaveChanges();

            return vaccinationCentre.Id;

        }

        public bool Delete(int id)
        {
            _logger.LogWarning($"Vaccination centre with id: {id} DELETE action invoked");

            var vaccinationCentre = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);
            if(vaccinationCentre is null)
            {
                return false;
            }

            _dbContext.VaccinationCentres.Remove(vaccinationCentre);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
