using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    public class VaccinatorDto
    {
        public int Id { get; set; }
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
