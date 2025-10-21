using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using PMApplication.Interfaces.RepositoryInterfaces;

namespace PMApplication.Services
{
    public class PartService : IPartService
    {
        private readonly IPartRepository _partRepository;
        private readonly IPartTypeRepository _partTypeRepository;
        private readonly IStandTypeRepository _standTypeRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPlanogramPartRepository _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public PartService(IPartRepository partRepository, IMapper mapper, IPartTypeRepository partTypeRepository, IStandTypeRepository standTypeRepository, ICategoryRepository categoryRepository, ILogger<PartService> logger, IPlanogramPartRepository planogramPartRepository)
        {
            _partRepository = partRepository;
            _mapper = mapper;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
            _logger = logger;
            _planogramPartRepository = planogramPartRepository;
        }

        public Task<IReadOnlyList<Part>> GetParts(PartFilter partFilter)
        {
            try
            {
                var spec = new PartSpecification(partFilter);
                return _partRepository.ListAsync(spec);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new NotImplementedException("Method not implemented yet.", ex);
            }
        }

        public Part GetPart(int id)
        {
            var part = _partRepository.GetByIdAsync(id);
            return part.Result;
        }

        public Task<IReadOnlyList<PlanogramPart>> GetNonMarketParts(PlanogramPartFilter filter)
        {
            try
            {
                var spec = new PlanogramPartFilterSpecification(filter);
                var parts = _planogramPartRepository.ListAsync(spec);
                return parts;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new NotImplementedException("Method not implemented yet.", ex);
            }
        }

        public async Task<IReadOnlyList<PartInfo>> GetFilteredParts(int brandId, int? page, int? pageSize, string sortBy, string sortOrder, string searchString,
            int? partTypeId, int? parentCategoryId, int? categoryId, int? countryId, int? regionId, int? standTypeId)
        {
            return await _partRepository.GetFilteredParts(brandId,partTypeId, parentCategoryId, categoryId, countryId, regionId, standTypeId, page, pageSize, sortBy, sortOrder, searchString, false);
        }

        public async Task<IReadOnlyList<PartInfo>> GetFilteredShopParts(int brandId, int? page, int? pageSize, string sortBy, string sortOrder,
            string searchString, int? partTypeId, int? parentCategoryId, int? categoryId, int? countryId, int? regionId,
            int? standTypeId)
        {
            return await _partRepository.GetFilteredParts(brandId, partTypeId, parentCategoryId, categoryId, countryId, regionId, standTypeId, page, pageSize, sortBy, sortOrder, searchString, true);
        }


        public async Task<IReadOnlyList<PartType>> GetPartTypes()
        {
            try
            {
                //var spec = new PartSpecification(partFilter);
                return await _partTypeRepository.ListAllAsync();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new NotImplementedException("Method not implemented yet.", ex);
            }
        }

        //public IEnumerable<Part> GetMenuParts(int countryId, int categoryId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Part> GetMenuParts()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Part> GetMenuParts(int brandId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Part> GetMenuParts(int countryId, int categoryId, int brandId)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IReadOnlyList<PlanmMenuPart>?> GetPlanmMenu(PartFilter filter)
        {
            try
            {

                return await _partRepository.GetPlanmMenu((int)filter.BrandId, (int)filter.CountryId, (int)filter.StandTypeId);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public Part GetPart(string partNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<Part> CreatePart(Part part)
        {
            var savedPart = await _partRepository.AddAsync(part);
            return savedPart;
        }

        public Task DeletePart(int id)
        {
            throw new NotImplementedException();
        }

        public Task ReloadPart(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PartType> GetPartType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
