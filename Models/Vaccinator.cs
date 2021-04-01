using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    [Table("Vaccinators")]
    public class Vaccinator
    {
        [Key]
        public int VaccinatorId { get; set; }
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
        [DisplayName("Data urodzenia")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Typ szczepiącego")]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
