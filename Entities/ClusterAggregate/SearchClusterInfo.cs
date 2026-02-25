using System.ComponentModel.DataAnnotations;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

public partial class SearchClusterInfo 
{
    [Key]
    public long Id { get; set; }

    public string Name { get; set; } = null!;
    public string? ClusterPartNumber { get; set; }
    public int StandId { get; set; }
    public string? StandName { get; set; } = null!;
    public string? StandTypeName { get; set; } = null!;
    public string? StandAssemblyNumber { get; set; } = null!;
    public string? Description { get; set; }

    public int? Rows { get; set; }

    public int? Cols { get; set; }
    public Int16 Height { get; set; }

    public Int16 Width { get; set; }

    public int? ShelfIncrement { get; set; }


    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public bool Published { get; set; }

    public int StatusId { get; set; }

    public int BrandId { get; set; }


    public string? Lubname { get; set; }
    public string? RegionsList { get; set; }
    public string? CountriesList { get; set; }

    //public string? ImageSrc { get; set; }
    //public string? Header { get; set; }
    //public DateTime DateAvailable { get; set; }
    //public int LegacyUserId { get; set; }
    //public int? HeaderHeight { get; set; }
    //public int CurrentVersion { get; set; }
    //public int? ScratchPadId { get; set; }
    //public string? UserId { get; set; }
    //public string? UserName { get; set; }

}
