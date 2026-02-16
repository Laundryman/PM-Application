using PMApplication.Interfaces;

namespace PMApplication.Entities.JobsAggregate;

public partial class Job : BaseEntity<int>, IAggregateRoot
{
    public string JobCode { get; set; } = null!;

    public int BrandId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Description2 { get; set; }

    public string? CreatedBy { get; set; }

    public string? Reason { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime UploadedOn { get; set; }

    public int UploadedBy { get; set; }

    public string? OriginalFileName { get; set; }

    public int JobFolderId { get; set;  }
    public JobFolder JobFolder { get; set; }
}
