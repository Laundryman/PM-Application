using Microsoft.Graph.Drives.Item.Items.Item.GetActivitiesByInterval;
using PMApplication.Interfaces;

namespace PMApplication.Entities;


public partial class ActionReportDto
{

    public DateTime Date { get; set; }

    public string Message { get; set; } = null!;

    public string? BrandName { get; set; }

    public string? UserName { get; set; }

    public string? ActionName { get; set; }

    public string? PlanoName { get; set; }
    public string? ObjectName { get; set; }

    public string? Roles { get; set; }

    public string? RoleName { get; set; }
    public string? RegionName { get; set; }

    public string? CountryName { get; set; }

}
