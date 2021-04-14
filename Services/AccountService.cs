using Microsoft.AspNetCore.Identity;
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
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly ILogger<AccountService> _logger;

        public AccountService(VaccinationCentresContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public int RegisterUser(User user)
        {
            var hashedPassword = _passwordHasher.HashPassword(user, user.PasswordHash);
            user.PasswordHash = hashedPassword;

            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }
    }
}
