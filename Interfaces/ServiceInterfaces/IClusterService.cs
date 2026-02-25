using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.StandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IClusterService
    {
        bool ClusterHasPlanograms(int clusterId);

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
        void CreateCluster(Cluster cluster);
        void ReloadCluster(long id);
        void DeleteCluster(long id);

        Task<IReadOnlyList<ClusterShelf>> GetClusterShelves(ClusterFilter filter);
        ClusterShelf GetClusterShelf(long id);
        void SaveClusterShelf();
        void CreateClusterShelf(ClusterShelf clusterShelf);
        void DeleteClusterShelf(long id);

        Task<IReadOnlyList<ClusterPart>> GetClusterParts(ClusterFilter filter);
        ClusterPart GetClusterPart(long id);
        void SaveClusterPart();
        void CreateClusterPart(ClusterPart clusterPart);
        void DeleteClusterPart(long id);

    }
}
