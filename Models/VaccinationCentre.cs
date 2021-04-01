using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    [Table("VaccinationCentres")]
    public class VaccinationCentre
    {
        public int Id { get; set; }
        public string IsOpen { get; set; }
        public int AddressId { get; set; }
        public int VaccinatorId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        [ForeignKey("VaccinatorId")]
        public Vaccinator Vaccinator { get; set; }
    }
}
