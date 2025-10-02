using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class StandType : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? ParentStandTypeId { get; set; }

    public int? BrandId { get; set; }

    public bool Lock { get; set; }

    public string? StandImage { get; set; }

    public int? FullSectionColumnWidth { get; set; }

    public int? HalfSectionColumnWidth { get; set; }

    public bool HidePrices { get; set; }

    public virtual StandType ParentStandType { get; set; } = null!;
    public virtual ICollection<JobFolder> JobFolders { get; set; } = new List<JobFolder>();
}


// Custom comparer for the StandType class
public class StandTypeComparer : IEqualityComparer<StandType>
{
    // Countries are equal if their names and Id numbers are equal.
    public bool Equals(StandType x, StandType y)
    {

        //Check whether the compared objects reference the same data.
        if (Object.ReferenceEquals(x, y)) return true;

        //Check whether any of the compared objects is null.
        if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
            return false;

        //Check whether the products' properties are equal.
        return x.Id == y.Id && x.Name == y.Name;
    }

    // If Equals() returns true for a pair of objects
    // then GetHashCode() must return the same value for these objects.

    public int GetHashCode(StandType standType)
    {
        //Check whether the object is null
        if (Object.ReferenceEquals(standType, null)) return 0;

        //Get hash code for the Name field if it is not null.
        int hashStandTypeName = standType.Name == null ? 0 : standType.Name.GetHashCode();

        //Get hash code for the ID field.
        int hashStandTypeId = standType.Id.GetHashCode();

        //Calculate the hash code for the product.
        return hashStandTypeName ^ hashStandTypeId;
    }
}
