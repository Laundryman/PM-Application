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
    public interface IStandService
    {
        Dictionary<string, byte> GetLayoutTypes();
        Task<Stand> GetStand(int id);
        Task<Stand> GetStand(int id, bool includeColumnUprights);
        Task<IEnumerable<Stand>> GetStands();
        Task<IReadOnlyList<Stand>> GetStands(StandFilter filter);
        //IEnumerable<Stand> GetStandsForBrand(int brandId);
        //IEnumerable<Stand> GetStandsForCountry(int countryId);
        //IEnumerable<Stand> GetStandsForCountry(int brandId, int countryId);
        //IEnumerable<Stand> GetStandsByTypeForCountry(int standTypeId, int countryId);
        //IEnumerable<Stand> GetStandsWithClustersForCountry(int brandId, int parentStandTypeId, int countryId);
        //IEnumerable<Stand> GetBrandStandsWithClustersForCountry(int brandId, int StandTypeId, int countryId);
        //IEnumerable<Stand> GetStandsByTypeForBrand(int standTypeId, int brandId, bool includeDiscontinued = false);
        //IEnumerable<Stand> GetStandsByType(int standTypeId, int brandId, IEnumerable<Country> countries, bool include_discontinued);





        Task<StandType> GetStandType(int id);
        IEnumerable<StandType> GetStandTypes();
        IEnumerable<StandType> GetStandTypes(int brandId);
        IEnumerable<StandType> GetStandTypesWithStands(int brandId);
        IEnumerable<StandType> GetStandTypesWithStands(int brandId, int countryId);
        IEnumerable<StandType> GetChildStandTypes(int parentStandTypeId);
        IEnumerable<StandType> GetChildStandTypesByBrand(int brandId, int parentStandTypeId);

        IEnumerable<StandType> GetFilteredStandTypes(int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable);


        void CreateStandType(StandType standType);
        void DeleteStandType(int standTypeId, int brandId);
        void SaveStandType();


        //IEnumerable<Stand> GetCountries(int standId);

        void SaveStand();
        void CreateStand(Stand stand);
        void DeleteStand(int id);
        void ReloadStand(int id);
        bool HasClusters(int id);
        bool HasPlanograms(int id);
        bool ClusterHasPlanograms(int clusterId);

        IEnumerable<Cluster> GetClusters();
        IEnumerable<Cluster> GetClusters(int countryId);
        IEnumerable<Cluster> GetClustersByBrand(int brandId, bool published);
        IEnumerable<Cluster> GetAllClustersByBrand(int brandId);
        IEnumerable<Cluster> GetClustersForStand(int standId);
        IEnumerable<Cluster> GetClustersByTypeForBrand(int standTypeId, int brandId);
        IEnumerable<Cluster> GetAllClustersByTypeForBrand(int standTypeId, int brandId);
        IEnumerable<Cluster> GetClustersByTypeForBrand(int standTypeId, int brandId, int countryId);
        Cluster GetCluster(int id);
        XmlDocument GetClusterXML(int id, int userId, string rootPath);
        void SaveCluster();
        void CreateCluster(Cluster cluster);
        void ReloadCluster(int id);
        void DeleteCluster(int id);

        IEnumerable<ClusterShelf> GetClusterShelves();
        ClusterShelf GetClusterShelf(int id);
        void SaveClusterShelf();
        void CreateClusterShelf(ClusterShelf clusterShelf);
        void DeleteClusterShelf(int id);

        IEnumerable<ClusterPart> GetClusterParts();
        ClusterPart GetClusterPart(int id);
        void SaveClusterPart();
        void CreateClusterPart(ClusterPart clusterPart);
        void DeleteClusterPart(int id);

        IEnumerable<StandColumn> GetStandColumns(int standId);
        StandColumn GetStandColumn(int id);
        void SaveStandColumn();
        void CreateStandColumn(StandColumn standColumn);
        void DeleteStandColumn(int id);

        IEnumerable<StandColumnUpright> GetStandColumnUprights(int columnId);
        StandColumnUpright GetStandColumnUpright(int id);
        void SaveStandColumnUpright();
        void CreateStandColumnUpright(StandColumnUpright standColumnUpright);
        void DeleteStandColumnUpright(int id);

        IEnumerable<StandRow> GetStandRows(int standId);
        StandRow GetStandRow(int id);
        void SaveStandRow();
        void CreateStandRow(StandRow standRow);
        void DeleteStandRow(int id);
    }
}
