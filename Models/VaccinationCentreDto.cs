using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    public class VaccinationCentreDto
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Czy otwarte")]
        [MaxLength(5)]
        public string IsOpen { get; set; }
        [Required]
        [DisplayName("Miejscowość")]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [DisplayName("Ulica")]
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [DisplayName("Numer domu")]
        public int HomeNumber { get; set; }
        [Required]
        [DisplayName("Typ punktu szczepień")]
        [MaxLength(50)]
        public string Type { get; set; }
        [Required]
        [DisplayName("Województwo")]
        [MaxLength(50)]
        public string Voivodeship { get; set; }
        [Required]
        [DisplayName("Kod pocztowy")]
        [MaxLength(12)]
        public string PostCode { get; set; }
    }
}
