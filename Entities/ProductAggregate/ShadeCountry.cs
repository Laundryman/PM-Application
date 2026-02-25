#nullable disable

using PMApplication;
using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Entities.ProductAggregate
{
    public partial class ShadeCountry
    {
        public long CountryId { get; set; }
        public long ShadeId { get; set; }

        public Country Country { get; set; } = null;
        public Shade Shade { get; set; } = null;
    }
}
