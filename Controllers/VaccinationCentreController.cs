using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;
using VaccinationCentres.Services;

namespace VaccinationCentres.Controllers
{
    [Route("api/vaccinationCentres")]
    public class VaccinationCentreController : ControllerBase
    {
        private readonly VaccinationCentresContext _dbContext;
        private readonly IVaccinationCentreService _centreService;

        public VaccinationCentreController(VaccinationCentresContext dbContext, IVaccinationCentreService centreService)
        {
            _dbContext = dbContext;
            _centreService = centreService;
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
            var vaccinationCentres = _centreService.GetAll();
            return Ok(vaccinationCentres);
        }

        [Route("getAddress/{id}")]
        [HttpGet]
        public ActionResult<VaccinationCentre> GetInfoAboutAddress([FromRoute] int id)
        {
            var vaccinationCentreDto = _centreService.GetAddressById(id);
            return Ok(vaccinationCentreDto);
        }

        [Route("getVaccinator/{id}")]
        [HttpGet]
        public ActionResult<VaccinationCentre> GetInfoAboutVaccinator([FromRoute] int id)
        {
            var vaccinatorDto = _centreService.GetVaccinatorById(id);
            return Ok(vaccinatorDto);
        }

        [HttpPost]
        public ActionResult CreateVaccinationCentre([FromBody] VaccinationCentre centre)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var id = _centreService.Create(centre);
            return Created($"/api/vaccinationCentres/{id}", null);
        }
    }
}
