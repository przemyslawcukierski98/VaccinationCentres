using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Adres e-mail")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        public string PasswordHash { get; set; }
        [Required]
        [DisplayName("Narodowość")]
        public string Nationality { get; set; }
        [Required]
        [DisplayName("Rola użytkownika")]
        public string Role { get; set; }
    }
}
