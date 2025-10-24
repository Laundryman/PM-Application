using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Specifications.Filters
{
    public class ShadeFilter : BaseFilter
    {
        public int BrandId { get; set; }
        public string ShadeNumber { get; set; }
        public string ShadeDescription { get; set; }
        public int ProductId { get; set; }
        public bool Published { get; set; }
        public string CountryList { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }

        //public new bool LoadChildren { get; set; }
        //public new bool IsPagingEnabled { get; set; }
        //public new int Page { get; set; }
        //public new int PageSize { get; set; }
    }
}
