using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class CountryRegion : BaseEntity<int>, IAggregateRoot
{
    public int RegionsId { get; set; }

    public int CountriesId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Region Region { get; set; } = null!;
}
