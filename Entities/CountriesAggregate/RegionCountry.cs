using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class RegionCountry : BaseEntity<int>, IAggregateRoot
{
    public int RegionId { get; set; }

    public long CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Region Region { get; set; } = null!;
}
