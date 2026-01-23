using System.ComponentModel.DataAnnotations;
using PMApplication.Dtos.StandTypes;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Dtos
{
    public partial class PartDto
    {


        [Key]
        public long? Id { get; set; }
        public int? BrandId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PartNumber { get; set; }
        public string? AltPartNumber { get; set; }
        public string? CustomerRefNo { get; set; }
        public bool? Published { get; set; }
        public bool? Discontinued { get; set; }
        public short? Facings { get; set; }
        public short? Height { get; set; }
        public short? Width { get; set; }
        public short? Depth { get; set; }
        public short? Stock { get; set; }
        public string? RegionList { get; set; }
        public string? CountriesList { get; set; }

        public int? CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? ParentCategoryName { get; set; }
        public int? PartTypeId { get; set; }
        public string? PartTypeName { get; set; }
        public short? ShoppingHeight { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool? Shoppable { get; set; }
        public string? PackShotImageSrc { get; set; }
        public string? Render2dImage { get; set; }
        public string? SvgLineGraphic { get; set; }
        
        public decimal UnitCost { get; set; }
        public decimal? LaunchPrice { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string? Presentation { get; set; }
        public string? CassetteBio { get; set; }
        public string? ManufacturingProcess { get; set; }
        public string? TestingType { get; set; }
        public bool? internationalPart { get; set; }
        //public int?? StandTypeId { get; set; }
        public bool? DmiReco { get; set; }
        public bool? HidePrices { get; set; }
        //public string? CountryList { get; set; }
        public PartType PartType { get; set; }
        public List<ProductDto> Products { get; set; }
        public List<StandTypeDto> StandTypes { get; set; }
        public ICollection<RegionDto> Regions { get; set; }
        public ICollection<CountryDto> Countries { get; set; }


        //public int? TotalResults { get; set; }
        //public int? RowNum { get; set; }
        //public string? PlanoImageSrc { get; set; }

    }
}
