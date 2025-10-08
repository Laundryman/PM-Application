using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IStandTypeRepository : IAsyncRepository<StandType>
    {
        Task<IReadOnlyList<StandType>> GetFilteredStandTypes(int? brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable);
    }
}
