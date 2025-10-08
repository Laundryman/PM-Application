using PMApplication.Entities.CountriesAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IRegionService
    {
        Task<IReadOnlyList<Region>> GetRegions(RegionFilter filter);
        Task<IReadOnlyList<Region>> GetRegionsByBrand(int brandId);
        Task<IReadOnlyList<Region>> GetRegionsForCountryList(int brandId, List<Country> countryList);
        Task<Region> GetCountriesForRegion(int brandId);

        Task<Region> GetRegion(int id);
        void CreateRegion(Region region);
        void DeleteRegion(int id);
        void SaveRegion();

    }
}
