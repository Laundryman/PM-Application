using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmPlanogramInfo
    {
        public int? PlanogramId { get; set; }
        public string? PlanogramName { get; set; }
        public int? ClusterId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int? CountryId { get; set; }
        public string? UserRoles { get; set; }

        public PlanmShelfInfoList? PlanogramInfo { get; set; }
        public PlanmShelfInfoList? ScratchPadInfo { get; set; }
        public PlanmShelfInfoList? DeletedInfo { get; set; }
        public IEnumerable<PlanmPartInfo>? cassetteInfo { get; set; } //this is for cassettes/accessories without a shelf
    }
}
