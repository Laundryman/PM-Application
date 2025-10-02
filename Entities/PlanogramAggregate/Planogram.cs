using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class Planogram : BaseEntity<long>, IAggregateRoot
{
    public long ClusterId { get; set; }

    public string Name { get; set; } = null!;

    public string? OrderRef { get; set; }

    public string? Description { get; set; }

    public int StatusId { get; set; }

    public string? PlanogramPreviewSrc { get; set; }

    public int StandId { get; set; }

    public int LegacyUserId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public DateTime? DateSubmitted { get; set; }

    public int CurrentVersion { get; set; }

    public bool Template { get; set; }

    public long? ScratchPadId { get; set; }

    public int? LegacyLastUpdatedBy { get; set; }

    public int? CountryId { get; set; }

    public bool Archived { get; set; }

    public int? LegacyArchivedBy { get; set; }

    public DateTime? ArchivedDate { get; set; }

    public string? JobNumber { get; set; }

    public int? BrandId { get; set; }

    public string? UserId { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LegacyArchivedId { get; set; }

    public string? UserName { get; set; }

    public string? LubName { get; set; }

    public string? ArchivedByName { get; set; }

    public string? ArchivedBy { get; set; }

    public int? JobId { get; set; }

    public virtual Cluster Cluster { get; set; } = null!;
    public virtual ScratchPad ScratchPad { get; set; } = null!;

    public virtual ICollection<PlanogramNote> PlanogramNotes { get; set; } = new List<PlanogramNote>();

    public virtual ICollection<PlanogramPartFacing> PlanogramPartFacings { get; set; } = new List<PlanogramPartFacing>();

    public virtual ICollection<PlanogramPart> PlanogramParts { get; set; } = new List<PlanogramPart>();

    public virtual ICollection<PlanogramShelf> PlanogramShelves { get; set; } = new List<PlanogramShelf>();

    public virtual Stand Stand { get; set; } = null!;

    public virtual PlanogramStatus Status { get; set; } = null!;
}
