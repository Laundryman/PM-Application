using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.StandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface ICountryService
    {
        Task<IReadOnlyList<Country>> GetCountries();
        //Enumerable<Country> GetActiveCountries();
        //IEnumerable<Country> GetAllActiveCountries();
        //IEnumerable<Country> GetCountriesByRegion(int regionId);
        //IEnumerable<Country> GetCountriesByRegion(int regionId, int brandId);
        Task<Country> GetCountry(int id);
        Task<Country?> GetCountry(string isoCode);
        void CreateCountry(Country country);
        void DeleteCountry(int id);
        void SaveCountry();

    }
}
