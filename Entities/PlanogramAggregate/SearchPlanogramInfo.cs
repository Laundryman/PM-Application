using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.PlanogramAggregate
{
    /// <summary>
    /// obsolete - use PlanmPlanogramDto instead
    /// </summary>
    public partial class SearchPlanogramInfo
    {
        [Key]
        public long Id { get; protected set; }
        public long? ClusterId { get; set; }
        public int? BrandId { get; set; }
        public long? ScratchPadId { get; set; }

        public string? Name { get; set; }
        public string? OrderRef { get; set; }
        public string? Description { get; set; }
        public int? StatusId { get; set; }
        public string? StatusName { get; set; }

        public string? PlanogramPreviewSrc { get; set; }
        public int? StandId { get; set; }
        public string? StandTypeName { get; set; }
        public string? StandName { get; set; }
        public short? StandHeight { get; set; }
        public short? StandWidth { get; set; }
        public string? UserId { get; set; }
        public int? LegacyUserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string? FormattedDateUpdated { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int CurrentVersion { get; set; }
        public bool Template { get; set; }
        public string? LastUpdatedBy { get; set; }
        public int? LegacyLastUpdatedBy { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? RegionId { get; set; }
        public string? RegionName { get; set; }
        public int? ShelfCount { get; set; }
        public int? AccessoryCount { get; set; }
        public string? UserName { get; set; }
        public string? LubName { get; set; }
        public string? JobNumber { get; set; }
        public int? JobId { get; set; }
        public bool HasComments { get; set; }
        public int? CommentCount { get; set; }
        public bool Locked { get; set; }
        public string? LockingUserId { get; set; }
        public string? LockingUserName { get; set; }
        public DateTime? DateLocked { get; set; }
    }
}
