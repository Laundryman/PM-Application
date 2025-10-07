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
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class ClusterService : IClusterService
    {
        private readonly IAsyncRepository<Stand> _standRepository;
        private readonly IAsyncRepository<PartType> _partTypeRepository;
        private readonly IAsyncRepository<StandType> _standTypeRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        //private readonly IPartRepository _partRepositorySync;
        //private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public ClusterService(IAsyncRepository<Stand> standRepository, IAsyncRepository<PartType> partTypeRepository, IAsyncRepository<StandType> standTypeRepository, IAsyncRepository<Category> categoryRepository)
        {
            _standRepository = standRepository;
            _partTypeRepository = partTypeRepository;
            _standTypeRepository = standTypeRepository;
            _categoryRepository = categoryRepository;
        }


        public bool ClusterHasPlanograms(int clusterId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Cluster>> GetClusters(ClusterFilter filter)
        {
            throw new NotImplementedException();
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
