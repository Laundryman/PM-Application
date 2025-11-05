using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PMApplication.Dtos.PlanModels;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
  public interface IPartService
    {
        Task<IReadOnlyList<Part>> GetParts(PartFilter partFilter);
        Task<Part> GetPart(int id);
        Task<Part> GetPart(PartFilter partFilter);

        //Task<IReadOnlyList<Part>> GetParts(int countryId);
        //Task<IReadOnlyList<Part>> GetParts(int countryId, int CategoryId);
        //Task<IReadOnlyList<Part>> GetParts(int brandId, int categoryId, IEnumerable<Country> countries, bool noTracking = false);
        //Task<IReadOnlyList<Part>> GetParts(int brandId, int categoryId, int standTypeId, IEnumerable<Country> countries);
        //IEnumerable<Part> GetPartsForBrand(int brandId);
        //Task<IReadOnlyList<Part>> GetParts(int brandId, int partTypeId, int countryId);
        Task<IReadOnlyList<PlanogramPart>> GetNonMarketParts(PlanogramPartFilter filter);
        Task<IReadOnlyList<PartInfo>> GetFilteredParts(int brandId, int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? partTypeId,
            int? parentCategoryId,
            int? categoryId,
            int? countryId, int? regionId, int? standTypeId);

        Task<IReadOnlyList<PartInfo>> GetFilteredShopParts(int brandId, int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? partTypeId,
            int? parentCategoryId,
            int? categoryId,
            int? countryId, int? regionId, int? standTypeId);


        //IEnumerable<PagedPart> GetFilteredParts(int pageNo, int pageSize, string sortBy, string sortOrder, string searchString, int brandId, int regionId, int countryId, int categoryId, int partTypeId); 
        Task<IReadOnlyList<PartType>> GetPartTypes();

        //IEnumerable<Part> GetMenuParts(int countryId, int categoryId);
        //IEnumerable<Part> GetMenuParts();
        //IEnumerable<Part> GetMenuParts(int brandId);
        //IEnumerable<Part> GetMenuParts(int countryId, int categoryId, int brandId);


        Task<IReadOnlyList<PlanmMenuPart>?> GetPlanmMenu(PartFilter filter);
        Task<IReadOnlyList<Category>?> GetPlanmMenuCategories (PartFilter filter);
        //IEnumerable<PlanxMenuPart> GetPlanxCategoryMenu(int brandId, int categoryId, int countryId, string rootPath, int standTypeId, int standHeight, int standWidth);
        //IEnumerable<PlanxMenuPart> GetPlanxClusterMenu(int brandId, int clusterId, string rootPath, int standTypeId, int standHeight, int standWidth);
        //IEnumerable<PlanxMenuPart> GetPlanxCategoryClusterMenu(int brandId, int categoryId, string rootPath, int standId);

        Task<Part> GetPart(string partNumber);
        Task<Part> CreatePart(Part part);
        Task DeletePart(int id);
        Task ReloadPart(int id);
        Task<PartType> GetPartType(int id);
        //void CreatePartType(Part category);
        //void DeletePartType(int id);
        //void SavePartType();
    }
}
