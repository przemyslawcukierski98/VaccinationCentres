using System.Collections.Generic;
using VaccinationCentres.Models;

namespace VaccinationCentres.Services
{
    public interface IVaccinationCentreService
    {
        int Create(VaccinationCentre vaccinationCentre);
        VaccinationCentreDto GetAddressById(int id);
        IEnumerable<VaccinationCentre> GetAll(VaccinationCentreQuery query);
        VaccinatorDto GetVaccinatorById(int id);

        void Delete(int id);
    }
}