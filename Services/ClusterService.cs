using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models;
using PMApplication.Dtos;
using PMApplication.Dtos.PlanModels;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace PMApplication.Services
{
    public class ClusterService : IClusterService
    {
        private readonly IStandRepository _standRepository;
        private readonly IPartTypeRepository _partTypeRepository;
        private readonly IStandTypeRepository _standTypeRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IClusterRepository _clusterRepository;

        private readonly IClusterPartRepository _clusterPartRepository;
        private readonly IClusterShelfRepository _clusterShelfRepository;
        //private readonly IPartRepository _partRepositorySync;
        //private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public ClusterService(IStandRepository standRepository, IPartTypeRepository partTypeRepository, IStandTypeRepository standTypeRepository, ICategoryRepository categoryRepository, IClusterRepository clusterRepository, IMapper mapper, ILogger<PartService> logger, IClusterPartRepository clusterPartRepository, IClusterShelfRepository clusterShelfRepository)
        {
            _standRepository = standRepository;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
            _clusterRepository = clusterRepository;
            _mapper = mapper;
            _logger = logger;
            _clusterPartRepository = clusterPartRepository;
            _clusterShelfRepository = clusterShelfRepository;
        }


        public bool ClusterHasPlanograms(int clusterId)
        {
            throw new NotImplementedException();
        }

        public async Task<long> CreateCluster(CreateLayoutDto newClusterDetails, CurrentUser userProfile)
        {
            try
            {
                Cluster layout = new Cluster();

                var stand = await _standRepository.GetByIdAsync(newClusterDetails.StandId);
                var standType = await _standTypeRepository.GetByIdAsync(newClusterDetails.StandTypeId);

                layout.BrandId = newClusterDetails.BrandId;
                layout.CurrentVersion = 1;
                layout.DateCreated = DateTime.Now;
                layout.DateUpdated = DateTime.Now;
                layout.Name = newClusterDetails.Name ?? "";
                //planogram.Stand = cluster.Stand;
                layout.StandTypeId = newClusterDetails.StandTypeId;
                layout.StandTypeName = standType.Name;
                layout.StandName = stand.Name;
                layout.StandAssemblyNumber = stand.StandAssemblyNumber ?? "";
                layout.StandId = newClusterDetails.StandId;
                layout.Height = stand.Height;
                layout.Width = stand.Width;
                //planogram.Status = 1;
                layout.StatusId = 1;
                layout.UserId = userProfile.Id;
                //layout.CountriesList = newClusterDetails.CountryId;
                //layout.RegionsList = newClusterDetails.R;
                layout.UserName = userProfile.DisplayName;
                layout.Lubname = userProfile.GivenName + " " + userProfile.Surname;
                //layout.LastUpdatedBy = userProfile.Id;
                //planogram.CountryId = (int)oauthService.GetUserProfile(userId).CountryId;
                layout.CountriesList = newClusterDetails.CountryIds;
                layout.RegionsList = newClusterDetails.RegionIds;
                await CreateLayout(layout);

                //Add Promos > now accessories

                //await SavePlanogram(planogram);
                return layout.Id;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error creating planogram from cluster: " + ex.Message);
                throw;
            }
        }

        public Task<IReadOnlyList<Cluster>> GetClusters(ClusterFilter filter)
        {
            try
            {
                var spec = new ClusterSpecification(filter);
                return _clusterRepository.ListAsync(spec);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting clusters with filter {@Filter}", filter);
                throw;
            }
        }

        public async Task<Cluster> GetCluster(long id)
        {
            try
            {
                return await _clusterRepository.GetByIdAsync(id);

            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error getting planogram: " + ex.Message);
                throw;
            }
        }

        public async Task<Cluster> GetCluster(ClusterFilter filter)
        {
            var spec = new ClusterSpecification(filter);
            var cluster = await _clusterRepository.FirstAsync(spec);
            return cluster;
        }

        public void SaveCluster()
        {
            throw new NotImplementedException();
        }

        public async Task CreateLayout(Cluster cluster)
        {
            try
            {
                await _clusterRepository.AddAsync(cluster);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "Error creating cluster");
                throw;
            }
        }

        public void ReloadCluster(long id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCluster(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<ClusterShelf>> GetClusterShelves(ClusterFilter filter)
        {
            try
            {
                filter.IncludeShelves = true;
                var spec = new GetClusterShelvesSpecification(filter);
                var clusterShelves = await _clusterShelfRepository.ListAsync(spec);
                return clusterShelves.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting clusters with filter {@Filter}", filter);
                throw;
            }
        }

        public async Task<ClusterShelf> GetClusterShelf(long id)
        {
            try
            {
                var shelf = await _clusterShelfRepository.GetByIdAsync(id);
                return shelf;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error getting cluster shelf: " + ex.Message);
                throw;
            }
        }

        public async Task UpdateClusterShelf(ClusterShelf shelf)
        {
            try
            {
                await _clusterShelfRepository.UpdateAsync(shelf);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error saving cluster shelf: " + ex.Message);
                throw;
            }
        }

        public async Task SaveClusterShelf(ClusterShelf clusterShelf)
        {
            try
            {
                await _clusterShelfRepository.UpdateAsync(clusterShelf);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error saving cluster shelf: " + ex.Message);
                throw;
            }
        }

        public async Task CreateClusterShelf(ClusterShelf clusterShelf)
        {
            try
            {
                await _clusterShelfRepository.AddAsync(clusterShelf);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error adding cluster shelf: " + ex.Message);
                throw;
            }
        }

        public async Task DeleteClusterShelf(long id)
        {
            try
            {
                var shelf = await _clusterShelfRepository.GetByIdAsync(id);
                if (shelf != null)
                {
                    await _clusterShelfRepository.DeleteAsync(shelf);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error deleting cluster shelf: " + ex.Message);
                throw;
            }

        }

        public async Task<IReadOnlyList<ClusterPart>> GetClusterParts(ClusterPartFilter filter)
        {
            try
            {
                var spec = new GetClusterPartsSpecification(filter);
                var clusterParts = await _clusterPartRepository.ListAsync(spec);
                return clusterParts.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting clusters with filter {@Filter}", filter);
                throw;
            }
        }

        public async Task<ClusterPart> GetClusterPart(long id)
        {
            try
            {
                return await _clusterPartRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error getting planogram part: " + ex.Message);
                throw;
            }
        }

        public async Task SaveClusterPart(ClusterPart clusterPart)
        {
            try
            {
                await _clusterPartRepository.UpdateAsync(clusterPart);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error updating planogram part: " + ex.Message);
                throw;
            }

        }

        public async Task CreateClusterPart(ClusterPart clusterPart)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteClusterPart(long id)
        {
            try
            {
                var clusterPart = await _clusterPartRepository.GetByIdAsync(id);
                if (clusterPart != null)
                {
                    await _clusterPartRepository.DeleteAsync(clusterPart);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error deleting cluster part: " + ex.Message);
                throw;
            }
        }

    }
}
