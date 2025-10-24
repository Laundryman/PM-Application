using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Entities.StandAggregate;

public partial class StandCountry
{
    public long CountryId { get; set; }

    public int StandId { get; set; }

    public virtual Country Country { get; set; } = null!;
    public virtual Stand Stand { get; set; } = null!;
}
