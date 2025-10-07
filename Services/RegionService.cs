using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class RegionService : IRegionService
    {
        private readonly IAsyncRepository<Region> _regionRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CountryService> _logger;
        public Task<IReadOnlyList<Region>> GetRegions(RegionFilter filter)
        {
            var spec = new RegionSpecification(filter);
            var regions = _regionRepository.ListAsync(spec);
            return regions;
        }

        public Task<IReadOnlyList<Region>> GetRegionsByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Region>> GetRegionsForCountryList(int brandId, List<Country> countryList)
        {
            throw new NotImplementedException();
        }

        public async Task<Region> GetRegion(int id)
        {
            var region = await _regionRepository.GetByIdAsync(id);
            return region;
        }

        public void CreateRegion(Region region)
        {
            throw new NotImplementedException();
        }

        public void DeleteRegion(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveRegion()
        {
            throw new NotImplementedException();
        }
    }
}
