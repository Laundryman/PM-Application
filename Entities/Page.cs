using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Page : BaseEntity<int>, IAggregateRoot
{
    public string? PageName { get; set; }

    public string? ContentArea { get; set; }

    public string? TemplateName { get; set; }

    public string? HeaderImage { get; set; }

    public DateTime? DateUpdated { get; set; }
}
