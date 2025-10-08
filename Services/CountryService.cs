using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using AutoMapper;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Interfaces.RepositoryInterfaces;

namespace PMApplication.Services
{
    public class CountryService: ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CountryService> _logger;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }






#region ICountryService Members
        public Task<IReadOnlyList<Country>> GetCountries(CountryFilter filter)
        {
            try
            {
                var spec = new CountrySpecification(filter);
                return _countryRepository.ListAsync(spec);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "Error retrieving stands with filter: {Filter}", filter);
                return null;
            }
        }

        public async Task<Country> GetCountry(int id)
        {
            //var country = await _countryRepository.GetByIdAsync(id);
            var getCountrySpec = new GetCountrySpec(id);
            var country = await _countryRepository.ListAsync(getCountrySpec);
            return country.FirstOrDefault();
        }

        /// <summary>
        /// Get Country by ISO Code / three letter code
        /// </summary>
        /// <param name="isoCode"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Country?> GetCountry(string isoCode)
        {
            return _countryRepository.ListAsync(new CountrySpecification(new CountryFilter { IsoCode = isoCode })).Result.FirstOrDefault();
        }

        public void CreateCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveCountry()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
