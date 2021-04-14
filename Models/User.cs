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
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }

        public string PhoneNumber { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string Nationality { get; set; }
        public string Role { get; set; }
    }
}
