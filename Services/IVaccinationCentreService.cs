using System.Collections.Generic;
using VaccinationCentres.Models;

namespace VaccinationCentres.Services
{
    public interface IVaccinationCentreService
    {
        int Create(VaccinationCentre vaccinationCentre);
        VaccinationCentreDto GetAddressById(int id);
        IEnumerable<VaccinationCentre> GetAll(string searchPhrase);
        VaccinatorDto GetVaccinatorById(int id);

        void Delete(int id);
    }
}