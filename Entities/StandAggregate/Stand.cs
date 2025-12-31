using ApplicationCore.Entities;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMApplication.Entities.StandAggregate;

public partial class Stand : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public short Height { get; set; }

    public short Width { get; set; }

    public string?  StandTypeName { get; set; }
    public int StandTypeId { get; set; }

    public int? MerchHeight { get; set; }

    public int? MerchWidth { get; set; }

    public int HeaderHeight { get; set; }

    public int? HeaderWidth { get; set; }

    public string? HeaderGraphic { get; set; }

    public int FooterHeight { get; set; }

    public int? FooterWidth { get; set; }

    public int? HorizontalPitchCount { get; set; }

    public int? HorizontalPitchSize { get; set; }

    public int? Cols { get; set; }

    public bool? EqualCols { get; set; }

    public int? DefaultColWidth { get; set; }

    public string? StandAssemblyNumber { get; set; }

    public byte? LayoutStyle { get; set; }

    public bool? SpanShelves { get; set; }

    public int? Rows { get; set; }

    public bool? EqualRows { get; set; }

    public int? DefaultRowHeight { get; set; }

    public int? ShelfIncrement { get; set; }

    public decimal? StandCost { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public DateTime DateAvailable { get; set; }

    public bool Published { get; set; }

    public bool? Discontinued { get; set; }

    public int BrandId { get; set; }

    public bool? AllowOverHang { get; set; }

    public int? ParentStandTypeId { get; set; }
    [ForeignKey("StandTypeId")]

    public virtual StandType StandType { get; set; } = null!;
    public virtual Brand Brand{ get; set; } = null!;

    public virtual List<Country> Countries { get; set; } = [];
    //public virtual List<StandCountry> StandCountries { get; } = [];

    //public virtual List<CountryRegion> CountryRegions { get; } = [];

    public virtual List<Cluster> Clusters { get; set; } = [];

    public virtual List<Planogram> Planograms { get; set; } = [];

    public virtual List<Part> Parts { get; set; } = [];
    public virtual List<StandColumn> ColumnList { get; set; } = [];
    public virtual List<StandRow> RowList { get; set; } = [];


    //public virtual List<StandPart> StandParts { get; set; } = [];
}
