using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class JobDto
    {
        public int Id { get; set; }
        public string? JobCode { get; set; }
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public string? CustomerCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }
        public string? CreatedBy { get; set; }
        public string? Reason { get; set; }
        public int UploadedBy { get; set; }
        public int JobFolderId {  get; set; }
        public string? JobFolderName { get; set; }
        public string? UploadedOn { get; set; }
        public string? DateFrom { get; set; }
        public string? DateTo { get; set; }
    }
}
