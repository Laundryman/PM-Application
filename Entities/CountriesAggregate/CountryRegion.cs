using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class CountryRegion : BaseEntity<int>, IAggregateRoot
{
    public int RegionId { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Region Region { get; set; } = null!;
}
