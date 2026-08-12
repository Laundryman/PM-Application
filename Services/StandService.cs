using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.RepositoryInterfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class StandService : IStandService
    {
        private readonly IStandRepository _standRepository;
        private readonly IPartTypeRepository _partTypeRepository;
        private readonly IStandTypeRepository _standTypeRepository;
        private readonly ICategoryRepository _categoryRepository;
        //private readonly IPartRepository _partRepositorySync;
        //private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<StandService> _logger;

        public StandService(IStandRepository standRepository, IPartTypeRepository partTypeRepository, IStandTypeRepository standTypeRepository, ICategoryRepository categoryRepository, ILogger<StandService> logger, IMapper mapper)
        {
            _standRepository = standRepository;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Stand> GetStand(int id)
        {
            var part = _standRepository.GetByIdAsync(id);
            return part.Result;
        }

        public async Task<Stand> GetStand(StandFilter filter)
        {
            var spec = new StandSpecification(filter);
            var stand = await _standRepository.FirstAsync(spec);
            //var part
            return stand;
        }

        public Task<IEnumerable<Stand>> GetStands()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Stand>> GetStands(StandFilter standFilter)
        {
            try
            {
                var spec = new StandSpecification(standFilter);
                return _standRepository.ListAsync(spec);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "Error retrieving stands with filter: {Filter}", standFilter);
                return null;
            }
        }





        public async Task<StandType> GetStandType(int id)
        {
            var standType = await _standTypeRepository.GetByIdAsync(id);
            return standType;
        }

        public async Task<StandType?> GetStandType(StandTypeFilter filter)
        {
            var spec = new StandTypeByIdSpecification(filter);
            var standTypes = await _standTypeRepository.ListAsync(spec);
            return standTypes.FirstOrDefault();

        }

        public async Task<IReadOnlyList<StandType>> GetStandTypes(StandTypeFilter filter)
        {
            var spec = new StandTypeSpecification(filter);
            return await _standTypeRepository.ListAsync(spec);
        }


        public async Task<IReadOnlyList<StandType>> GetFilteredStandTypes(int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId,
            int? partId, bool shoppable)
        {
            var standTypes = _standTypeRepository.GetFilteredStandTypes(brandId, regionId, countryId, categoryId, parentCategoryId,
                partId, shoppable);
            return await standTypes;
        }

        public void CreateStandType(StandType standType)
        {
            throw new NotImplementedException();
        }

        public void DeleteStandType(int standTypeId, int brandId)
        {
            throw new NotImplementedException();
        }

        public void SaveStandType()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, byte> GetLayoutTypes()
        {
            throw new NotImplementedException();
        }

        public void SaveStand()
        {
            throw new NotImplementedException();
        }

        public void CreateStand(Stand stand)
        {
            throw new NotImplementedException();
        }

        public void DeleteStand(int id)
        {
            throw new NotImplementedException();
        }

        public void ReloadStand(int id)
        {
            throw new NotImplementedException();
        }

        public bool HasClusters(int id)
        {
            throw new NotImplementedException();
        }

        public bool HasPlanograms(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<StandColumn> GetStandColumns(int standId)
        {
            throw new NotImplementedException();
        }

        public StandColumn GetStandColumn(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveStandColumn()
        {
            throw new NotImplementedException();
        }

        public void CreateStandColumn(StandColumn standColumn)
        {
            throw new NotImplementedException();
        }

        public void DeleteStandColumn(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StandColumnUpright> GetStandColumnUprights(int columnId)
        {
            throw new NotImplementedException();
        }

        public StandColumnUpright GetStandColumnUpright(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveStandColumnUpright()
        {
            throw new NotImplementedException();
        }

        public void CreateStandColumnUpright(StandColumnUpright standColumnUpright)
        {
            throw new NotImplementedException();
        }

        public void DeleteStandColumnUpright(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StandRow> GetStandRows(int standId)
        {
            throw new NotImplementedException();
        }

        public StandRow GetStandRow(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveStandRow()
        {
            throw new NotImplementedException();
        }

        public void CreateStandRow(StandRow standRow)
        {
            throw new NotImplementedException();
        }

        public void DeleteStandRow(int id)
        {
            throw new NotImplementedException();
        }
    }
}
