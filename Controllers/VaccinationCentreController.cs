using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "admin,user")]
        public ActionResult<VaccinationCentre> Get([FromRoute]int id)
        {
            var vaccinationCentre = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);
            return Ok(vaccinationCentre);
        }

        [HttpGet]
        [Authorize(Roles = "admin,user")]
        public ActionResult<VaccinationCentre> GetAll()
        {
            var vaccinationCentres = _centreService.GetAll();
            return Ok(vaccinationCentres);
        }

        [Route("getAddress/{id}")]
        [HttpGet]
        [Authorize(Roles = "admin,user")]
        public ActionResult<VaccinationCentre> GetInfoAboutAddress([FromRoute] int id)
        {
            var vaccinationCentreDto = _centreService.GetAddressById(id);
            return Ok(vaccinationCentreDto);
        }

        [Route("getVaccinator/{id}")]
        [HttpGet]
        [Authorize(Roles = "admin,user")]
        public ActionResult<VaccinationCentre> GetInfoAboutVaccinator([FromRoute] int id)
        {
            var vaccinatorDto = _centreService.GetVaccinatorById(id);
            return Ok(vaccinatorDto);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult CreateVaccinationCentre([FromBody] VaccinationCentre centre)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var id = _centreService.Create(centre);
            return Created($"/api/vaccinationCentres/{id}", null);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public ActionResult Delete([FromRoute] int id)
        {
            _centreService.Delete(id);
            return NoContent();
        }
    }
}
