using System.ComponentModel.DataAnnotations;
using ApplicationCore.Entities;
using Microsoft.Graph.Models;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class SearchStandInfo
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; } = null!;

    public string?  StandTypeName { get; set; }
    public string? ParentStandTypeName { get; set; }
    public int StandTypeId { get; set; }
    public int? ParentStandTypeId { get; set; }
    public string? RegionsList { get; set; }
    public string? CountriesList { get; set; }
    public int BrandId { get; set; }
    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }
    public bool Published { get; set; }

    public bool? Discontinued { get; set; }
    public int? Cols { get; set; }
    public int? Rows { get; set; }
    public bool? AllowOverHang { get; set; }
    public byte? LayoutStyle { get; set; }
    public string? StandAssemblyNumber { get; set; }
    public Int16 Height { get; set; }

    public Int16 Width { get; set; }
    public bool? SpanShelves { get; set; }

    //public int? MerchHeight { get; set; }

    //public int? MerchWidth { get; set; }

    //public int HeaderHeight { get; set; }

    //public int? HeaderWidth { get; set; }

    //public string? HeaderGraphic { get; set; }

    //public int FooterHeight { get; set; }

    //public int? FooterWidth { get; set; }

    //public int? HorizontalPitchCount { get; set; }

    //public int? HorizontalPitchSize { get; set; }


    //public bool? EqualCols { get; set; }

    //public int? DefaultColWidth { get; set; }

    //public bool? EqualRows { get; set; }

    //public int? DefaultRowHeight { get; set; }

    //public int? ShelfIncrement { get; set; }

    //public decimal? StandCost { get; set; }



    //public DateTime DateAvailable { get; set; }

}
