using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [DisplayName("Miejscowość")]
        [MaxLength(100)]
        public string City { get; set; }
        [DisplayName("Ulica")]
        [MaxLength(100)]
        public string Street { get; set; }
        [DisplayName("Numer domu")]
        public int HomeNumber { get; set; }
        [DisplayName("Typ punktu szczepień")]
        [MaxLength(50)]
        public string Type { get; set; }
        [DisplayName("Województwo")]
        [MaxLength(50)]
        public string Voivodeship { get; set; }
        [DisplayName("Kod pocztowy")]
        [MaxLength(12)]
        public string PostCode { get; set; }
    }
}
