#nullable disable

using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Entities
{
    public partial class ShadeCountry
    {
        public long CountryId { get; set; }
        public long ShadeId { get; set; }

        public Country Country { get; set; } = null;
        public Shade Shade { get; set; } = null;
    }
}
