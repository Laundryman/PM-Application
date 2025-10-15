using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.JobsAggregate;

public partial class JobFolder : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int ParentFolderId { get; set; }

    public int BrandId { get; set; }

    public int? RegionId { get; set; }

    public int? StandTypeId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Region? Region { get; set; }

    public virtual StandType? StandType { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
    public virtual ICollection<Job> Jobs { get; set; }

}
