using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationCentres.Models;

namespace VaccinationCentres.Services
{
    public interface IAccountService
    {
        int RegisterUser(User dto);
    }
}
