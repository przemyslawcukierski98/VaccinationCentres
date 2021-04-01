using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    [Table("VaccinationCentre")]
    public class VaccinationCentre
    {
        public int Id { get; set; }
        public string IsOpen { get; set; }
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
        [DisplayName("Imię")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [DisplayName("Numer telefonu")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [DisplayName("Adres e-mail")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }
    }
}
