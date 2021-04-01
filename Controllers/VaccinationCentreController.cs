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

        public IQueryable<VaccinationCentre> GetAll()
            => _dbContext.VaccinationCentres.Where(x => true);
    }
}
