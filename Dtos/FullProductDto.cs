namespace PMApplication.Dtos
{
    public class FullProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateAvailable { get; set; }
        public bool Published { get; set; }
        public string? ProductImage { get; set; }
        public bool? Discontinued { get; set; }
        public bool Hero { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? ParentCategoryName { get; set;}
        public List<PartListDto>? Parts { get; set; }
        //public ICollection<CountryDto> Countries { get; set; }

    }
}
