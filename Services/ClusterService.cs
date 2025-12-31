using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models;
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

namespace PMApplication.Services
{
    public class ClusterService : IClusterService
    {
        private readonly IStandRepository _standRepository;
        private readonly IPartTypeRepository _partTypeRepository;
        private readonly IStandTypeRepository _standTypeRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IClusterRepository _clusterRepository;
        //private readonly IPartRepository _partRepositorySync;
        //private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public ClusterService(IStandRepository standRepository, IPartTypeRepository partTypeRepository, IStandTypeRepository standTypeRepository, ICategoryRepository categoryRepository, IClusterRepository clusterRepository, IMapper mapper, ILogger<PartService> logger)
        {
            _standRepository = standRepository;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
            _clusterRepository = clusterRepository;
            _mapper = mapper;
            _logger = logger;
        }


        public bool ClusterHasPlanograms(int clusterId)
        {
            throw new NotImplementedException();
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

        public void CreateCluster(Cluster cluster)
        {
            throw new NotImplementedException();
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
                var spec = new ClusterSpecification(filter);
                var cluster = await _clusterRepository.FirstAsync(spec);
                return cluster.ClusterShelves.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting clusters with filter {@Filter}", filter);
                throw;
            }
        }

        public ClusterShelf GetClusterShelf(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveClusterShelf()
        {
            throw new NotImplementedException();
        }

        public void CreateClusterShelf(ClusterShelf clusterShelf)
        {
            throw new NotImplementedException();
        }

        public void DeleteClusterShelf(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<ClusterPart>> GetClusterParts(ClusterFilter filter)
        {
            try
            {
                filter.IncludeParts = true;
                var spec = new ClusterSpecification(filter);
                var cluster = await _clusterRepository.FirstAsync(spec);
                return cluster.ClusterParts.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting clusters with filter {@Filter}", filter);
                throw;
            }
        }

        public ClusterPart GetClusterPart(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveClusterPart()
        {
            throw new NotImplementedException();
        }

        public void CreateClusterPart(ClusterPart clusterPart)
        {
            throw new NotImplementedException();
        }

        public void DeleteClusterPart(long id)
        {
            throw new NotImplementedException();
        }

    }
}
