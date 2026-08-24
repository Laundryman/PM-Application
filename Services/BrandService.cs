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
using PMApplication.Interfaces.RepositoryInterfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using AutoMapper;

namespace PMApplication.Services
{
    public class BrandService: IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;       
        private readonly ILogger<BrandService> _logger;

        public BrandService(IBrandRepository brandRepository, IMapper mapper, ILogger<BrandService> logger)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _logger = logger;
        }

        #region IBrandService Members

        public async Task<IReadOnlyList<Brand>> GetBrands()
        {
            var brands = _brandRepository.ListAllAsync();
            return await brands;
        }

        public async Task<Brand> GetBrand(int id)
        {
            var brandFilter = new BrandFilter();
            brandFilter.Id = id;

            var spec = new BrandSpecification(brandFilter);
            var brand = await _brandRepository.GetByIdAsync(id);
            return brand ?? new Brand();
        }

        public async Task<Brand> CreateBrand(Brand brand)
        {
            await _brandRepository.AddAsync(brand);
            return brand;
        }

        public async Task DeleteBrand(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            Guard.Against.Null(brand, nameof(brand));
            await _brandRepository.DeleteAsync(brand);
        }


        #endregion

    }
}
