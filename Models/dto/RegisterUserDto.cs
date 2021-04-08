using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models.dto
{
    public class RegisterUserDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Role { get; set; } = "Admin";
    }
}
