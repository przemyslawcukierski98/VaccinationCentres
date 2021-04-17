using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationCentres.Models.dto
{
    public class LoginUserDto
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
