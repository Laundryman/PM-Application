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
using PMApplication.Dtos.PlanModels;

namespace PMApplication.Services
{
    public class PartService : IPartService
    {
        private readonly IAsyncRepositoryLong<Part> _partRepository;
        private readonly IAsyncRepository<PartType> _partTypeRepository;
        private readonly IAsyncRepository<StandType> _standTypeRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IPartRepository _partRepositorySync;
        private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public PartService(IAsyncRepositoryLong<Part> partRepository, IMapper mapper, IAsyncRepository<PartType> partTypeRepository, IAsyncRepository<StandType> standTypeRepository, IAsyncRepository<Category> categoryRepository, ILogger<PartService> logger, IPartRepository partRepositorySync, IAsyncRepositoryLong<PlanogramPart> planogramPartRepository)
        {
            _partRepository = partRepository;
            _mapper = mapper;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
            _logger = logger;
            _partRepositorySync = partRepositorySync;
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

        public async Task<IReadOnlyList<PartInfo>> GetFilteredParts(PartFilter partFilter)
        {
            try
            {
                var spec = new PartSpecification(partFilter);
                var parts = await _partRepository.ListAsync(spec);
                var partList = _mapper.Map<IReadOnlyList<PartInfo>>(parts);
                return partList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new NotImplementedException("Method not implemented yet.", ex);
            }
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

        public async Task<IReadOnlyList<MenuPartDto>?> GetPlanxMenu(int brandId, int countryId, int standTypeId)
        {
            try
            {

                return await _partRepositorySync.GetPlanxMenu(brandId, countryId, standTypeId);
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

        public Task CreatePart(Part part)
        {
            _partRepository.AddAsync(part);
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
