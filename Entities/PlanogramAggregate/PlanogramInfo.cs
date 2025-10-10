using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.PlanogramAggregate
{
    /// <summary>
    /// This entity represents the result of the GetPlanograms sproc
    /// </summary>
    public partial class PlanogramInfo
    {
        [Key] 
        public int Id { get; protected set; }
        public long PlanogramId { get; set; }
        public long ClusterId { get; set; }
        public string Name { get; set; }
        public string? OrderRef { get; set; }
        public string? Description { get; set; }
        public int StatusId { get; set; }
        public string PlanogramPreviewSrc { get; set; }
        public int StandId { get; set; }
        public string StandTypeName { get; set; }
        public string StandName { get; set; }
        public int StandHeight { get; set; }
        public int StandWidth { get; set; }
        public string UserId { get; set; }
        public int? LegacyUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string FormattedDateUpdated { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int CurrentVersion { get; set; }
        public bool Template { get; set; }
        public int? ScratchPadId { get; set; }
        public string LastUpdatedBy { get; set; }
        public int? LegacyLastUpdatedBy { get; set; }
        public int? CountryId { get; set; }
        public string RegionList { get; set; }
        public int ShelfCount { get; set; }
        public int AccessoryCount { get; set; }
        public string UserName { get; set; }
        public string LubName { get; set; }
        public string? JobNumber { get; set; }
        public int? JobId { get; set; }
        public bool HasComments { get; set; }
        public int CommentCount { get; set; }
        //public bool HasVersion { get; set; }
        public bool Locked { get; set; }
        public string LockingUserId { get; set; }
        public string LockingUserName { get; set; }
        public DateTime? DateLocked { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string UserEmail { get; set; }
        //public int UserCountryId { get; set; }
        //public string LubFirstName { get; set; }
        //public string LubLastName { get; set; }



    }
}
