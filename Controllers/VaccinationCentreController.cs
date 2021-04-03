using AutoMapper;
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
        private readonly IMapper _mapper;

        public VaccinationCentreController(VaccinationCentresContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
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
            var vaccinationCentresDto = _mapper.Map<List<VaccinationCentreDto>>(vaccinationCentres);
            return Ok(vaccinationCentres);
        }

        [Route("getShort/{id}")]
        [HttpGet]
        public ActionResult<VaccinationCentre> GetShort([FromRoute] int id)
        {
            var vaccinationCentre = _dbContext.VaccinationCentres.SingleOrDefault(x => x.Id == id);
            var vaccinationCentreDto = _mapper.Map<VaccinationCentreDto>(vaccinationCentre);
            return Ok(vaccinationCentreDto);
        }
    }
}
