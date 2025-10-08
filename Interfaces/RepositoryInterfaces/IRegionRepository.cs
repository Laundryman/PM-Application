using Ardalis.Specification;
using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IRegionRepository : IAsyncRepository<Region>
    {
        //Task<Region> GetRegion(ISpecification<Region> spec);
    }
}
