using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class StandRow : BaseEntity<int>, IAggregateRoot
{

    public int StandId { get; set; }

    public int Position { get; set; }

    public int Height { get; set; }
}
