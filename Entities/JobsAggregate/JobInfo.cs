using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.JobsAggregate
{
    public partial class JobInfo
    {
        [Key]
        public string JobCode { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadedOn { get; set; }
        //public string UploadingUserName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int TotalResults { get; set; }
        public int RowNum { get; set; }


    }
}