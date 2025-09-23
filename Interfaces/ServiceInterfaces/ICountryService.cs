using PMApplication.Entities.CountriesAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
        IEnumerable<Country> GetActiveCountries();
        IEnumerable<Country> GetAllActiveCountries();
        IEnumerable<Country> GetCountriesByRegion(int regionId);
        IEnumerable<Country> GetCountriesByRegion(int regionId, int brandId);
        Country GetCountry(int id);
        Country GetCountryByThreeLetterISO(string isoCode);
        void CreateCountry(Country country);
        void DeleteCountry(int id);
        void SaveCountry();

    }
}
