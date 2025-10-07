using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class JobDto
    {
        public string JobCode { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string CreatedBy { get; set; }
        public string Reason { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadedOn { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
