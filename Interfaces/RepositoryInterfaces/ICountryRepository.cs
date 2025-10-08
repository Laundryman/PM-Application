using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface ICountryRepository : IAsyncRepository<Country>
    {
        

    }
}
