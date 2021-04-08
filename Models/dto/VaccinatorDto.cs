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
        [Required]
        [DisplayName("Imię")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Nazwisko")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Numer telefonu")]
        [Phone]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Adres e-mail")]
        [EmailAddress]
        [MaxLength(100)]
        public string EmailAddress { get; set; }
    }
}
