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

        public Task<Cluster> GetCluster(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveCluster()
        {
            throw new NotImplementedException();
        }

        public void CreateCluster(Cluster cluster)
        {
            throw new NotImplementedException();
        }

        public void ReloadCluster(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCluster(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ClusterShelf>> GetClusterShelves()
        {
            throw new NotImplementedException();
        }

        public ClusterShelf GetClusterShelf(int id)
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

        public void DeleteClusterShelf(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClusterPart> GetClusterParts()
        {
            throw new NotImplementedException();
        }

        public ClusterPart GetClusterPart(int id)
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

        public void DeleteClusterPart(int id)
        {
            throw new NotImplementedException();
        }
    }
}
