using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;

namespace VaccinationCentres.Controllers
{
    [Route("api/vaccinationCentres")]
    public class VaccinationCentreController : ControllerBase
    {
        private readonly VaccinationCentresContext _dbContext;

        public VaccinationCentreController(VaccinationCentresContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public VaccinationCentre Get(int id)
            => _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);

        [HttpGet]
        public IQueryable<VaccinationCentre> GetAll()
            => _dbContext.VaccinationCentres.Where(x => true);


    }
}
