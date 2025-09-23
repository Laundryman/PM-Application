using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Shade : BaseEntity<long>, IAggregateRoot
{
    public string ShadeNumber { get; set; } = null!;

    public string ShadeDescription { get; set; } = null!;

    public long ProductId { get; set; }

    public bool Published { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public DateTime DateAvailable { get; set; }

    public string? Cmyk { get; set; }

    public string? Rgb { get; set; }

    public string? Pantone { get; set; }

    public string? CountryList { get; set; }

    public virtual ICollection<PlanogramPartFacing> PlanogramPartFacings { get; set; } = new List<PlanogramPartFacing>();

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
