using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    public class VaccinationCentresContext : DbContext
    {
        public VaccinationCentresContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<VaccinationCentre> VaccinationCentres { get; set; }
    }
}
