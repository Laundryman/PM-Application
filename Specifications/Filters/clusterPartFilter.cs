namespace PMApplication.Specifications.Filters
{
    public class ClusterPartFilter : BaseFilter
    {
        public long? ClusterId { get; set; }
        public int? CountryId { get; set; }
        public long? PartId { get; set; }
        public bool NewParts { get; set; }
    }
}
