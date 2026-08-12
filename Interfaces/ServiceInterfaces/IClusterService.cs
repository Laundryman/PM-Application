using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.StandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using PMApplication.Dtos;
using PMApplication.Dtos.PlanModels;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IClusterService
    {
        bool ClusterHasPlanograms(int clusterId);

        Task<long> CreateCluster(CreateLayoutDto newClusterDetails, CurrentUser userProfile);
        Task<IReadOnlyList<Cluster>> GetClusters(ClusterFilter filter);
        Task<Cluster> GetCluster(ClusterFilter filter);
        //IEnumerable<Cluster> GetClusters(int countryId);
        //IEnumerable<Cluster> GetClustersByBrand(int brandId, bool published);
        //IEnumerable<Cluster> GetAllClustersByBrand(int brandId);
        //IEnumerable<Cluster> GetClustersForStand(int standId);
        //IEnumerable<Cluster> GetClustersByTypeForBrand(int standTypeId, int brandId);
        //IEnumerable<Cluster> GetAllClustersByTypeForBrand(int standTypeId, int brandId);
        //IEnumerable<Cluster> GetClustersByTypeForBrand(int standTypeId, int brandId, int countryId);
        Task<Cluster> GetCluster(long id);
        void SaveCluster();
        Task CreateLayout(Cluster cluster);
        void ReloadCluster(long id);
        void DeleteCluster(long id);

        Task<IReadOnlyList<ClusterShelf>> GetClusterShelves(ClusterFilter filter);
        Task<ClusterShelf> GetClusterShelf(long id);
        Task UpdateClusterShelf(ClusterShelf shelf);

        Task SaveClusterShelf(ClusterShelf clusterShelf);
        Task CreateClusterShelf(ClusterShelf clusterShelf);
        Task DeleteClusterShelf(long id);

        Task<IReadOnlyList<ClusterPart>> GetClusterParts(ClusterPartFilter filter);
        Task<ClusterPart> GetClusterPart(long id);
        Task SaveClusterPart(ClusterPart clusterPart);
        Task CreateClusterPart(ClusterPart clusterPart);
        Task DeleteClusterPart(long id);

    }
}
