using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmClusterDto
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public int ClusterId { get; set; }
        public int StandId { get; set; }
        public int? ScratchPadId { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string OrderRef { get; set; }
        public string Description { get; set; }
        public string PlanogramPreviewSrc { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int CurrentVersion { get; set; }
        public bool Template { get; set; }
        public string standName { get; set; }
        public string standType { get; set; }
        public int standHeight { get; set; }
        public int standWidth { get; set; }
    }
}
