using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    /// <summary>
    /// obsolete - use PlanmPlanogramDto instead
    /// </summary>
    public class PlanogramDto
    {
        public int Id { get; set; }
        public int? BrandId { get; set; }
        public int LegacyUserId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int ClusterId { get; set; }
        public int? LegacyLastUpdatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedByName { get; set; }
        public int? CountryId { get; set; }
        public int StandId { get; set; }
        public int? ScratchPadId { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PlanogramPreviewSrc { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public DateTime? DateSubmitted { get; set; }
        public int CurrentVersion { get; set; }
        public bool Template { get; set; }
        public int? LegacyArchivedBy { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string JobNumber { get; set; }
        public bool Archived { get; set; }
    }
}
