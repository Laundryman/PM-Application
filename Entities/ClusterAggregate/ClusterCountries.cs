using Microsoft.EntityFrameworkCore;
using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

[PrimaryKey(nameof(CountryId), nameof(ClusterId))]
public partial class ClusterCountries : BaseEntity<int>
{
    public int CountryId { get; set; }

    public long ClusterId { get; set; }
}
