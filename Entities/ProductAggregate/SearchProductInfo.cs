using System.ComponentModel.DataAnnotations;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class SearchProductInfo
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string CategoryName { get; set; }
    public int CategoryId { get; set; }
    public string ParentCategoryName { get; set; }
    public int? ParentCategoryId { get; set; }
    public string? RegionsList { get; set; }
    public string? CountriesList { get; set; }
    public int BrandId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    //public DateTime? DateAvailable { get; set; }

    public bool Published { get; set; }
    public bool? Discontinued { get; set; }

    public string FullDescription { get; set; } = null!;
    public string? ShortDescription { get; set; }

    //public string? ProductImage { get; set; }


    //public bool Hero { get; set; }



}
