using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

public partial class ClusterCountry : BaseEntity<int>
{
    public int CountryId { get; set; }

    public long ClusterId { get; set; }
}
