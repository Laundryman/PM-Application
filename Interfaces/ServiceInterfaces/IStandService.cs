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
        Task<Stand> GetStand(StandFilter filter);
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

        Task<StandType?> GetStandType(StandTypeFilter filter);

        Task<IReadOnlyList<StandType>> GetStandTypes(StandTypeFilter filter);
        //IEnumerable<StandType> GetStandTypes(int brandId);
        //IEnumerable<StandType> GetStandTypesWithStands(int brandId);
        //IEnumerable<StandType> GetStandTypesWithStands(int brandId, int countryId);
        //IEnumerable<StandType> GetChildStandTypes(int parentStandTypeId);
        //IEnumerable<StandType> GetChildStandTypesByBrand(int brandId, int parentStandTypeId);

        Task<IReadOnlyList<StandType>> GetFilteredStandTypes(int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable);


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
