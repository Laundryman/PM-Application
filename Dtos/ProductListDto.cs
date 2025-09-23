namespace PMApplication.Dtos
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentCategoryId { get; set; }
        public string ParentCategoryName { get; set;}
        public string ProductImage { get; set; }
        public string CountryList { get; set; }

        public ProductListDto( string name, string shortDescription = "")
        {
            Name = name;
            ShortDescription = shortDescription;
        }
    }
}
