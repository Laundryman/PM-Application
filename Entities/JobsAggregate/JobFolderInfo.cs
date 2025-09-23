using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMApplication.Entities.JobsAggregate
{

    public partial class JobFolderInfo
    {


        [Key]
        public int Id { get; set; }
        public int ParentFolderId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        //public int? CountryId { get; set; }
        public int JobCount { get; set; }
        public int TotalResults { get; set; }
        public int RowNum { get; set; }



    }
}
