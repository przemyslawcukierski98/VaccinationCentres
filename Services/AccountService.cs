using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;
using VaccinationCentres.Models.dto;

namespace VaccinationCentres.Services
{
    public class AccountService : IAccountService
    {
        private readonly VaccinationCentresContext _context;
        private readonly ILogger<AccountService> _logger;

        public AccountService(VaccinationCentresContext context)
        {
            _context = context;
        }

        public int RegisterUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }
    }
}
