#nullable disable

using PMApplication;

namespace PMApplication.Entities.CountriesAggregate
{
    public partial class CountryProduct
    {
        public long CountryId { get; set; }
        public long ProductId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Product Product { get; set; }

        //-----------------------------------------------
        //ctors

        private CountryProduct() { }

        public CountryProduct(int countryId, int productId)
        {
            CountryId = countryId;
            ProductId = productId;
        }
    }
}
