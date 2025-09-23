#nullable disable

using PMApplication;
using PMApplication.Entities.JobsAggregate;

namespace PMApplication.Entities.CountriesAggregate
{
    public partial class CountryJobFolder
    {
        public long CountryId { get; set; }
        public int JobFolderId { get; set; }

        public virtual Country Country { get; set; }
        public virtual JobFolder JobFolder { get; set; }


        //-----------------------------------------------
        //ctors

        private CountryJobFolder() {  }

        public CountryJobFolder( int countryId, int jobFolderId)
        {
            CountryId = countryId;
            JobFolderId = jobFolderId;
        }

    }
}
