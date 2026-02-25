using PMApplication.Dtos.Filters;
using PMApplication.Entities.StandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IStandTypeRepository : IAsyncRepository<StandType>
    {
        Task<IReadOnlyList<StandType>> GetFilteredStandTypes(int? brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable);
        Task<IReadOnlyList<SearchStandInfo>> SearchStands(StandFilterDto filter);
    }
}
