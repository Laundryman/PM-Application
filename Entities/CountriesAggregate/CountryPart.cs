#nullable disable

using PMApplication;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Entities.CountriesAggregate
{
    public partial class CountryPart
    {
        public long CountryId { get; set; }
        public long PartId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Part Part { get; set; }


        //-----------------------------------------------
        //ctors

        //public CountryPart ( int countryId, int partId) 
        //{
        //    CountryId = countryId;
        //    PartId = partId;
        //}
    }
}
