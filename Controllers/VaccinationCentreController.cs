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
        public ActionResult<VaccinationCentre> Get([FromRoute]int id)
        {
            var vaccinationCentre = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);

            if(vaccinationCentre is null)
            {
                return NotFound();
            }
            return Ok(vaccinationCentre);
        }

        [HttpGet]
        public ActionResult<VaccinationCentre> GetAll()
        {
            var vaccinationCentres = _dbContext.VaccinationCentres.Where(x => true);
            return Ok(vaccinationCentres);
        }
    }
}
