using System.ComponentModel.DataAnnotations;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Permission: BaseEntity<int>, IAggregateRoot
{
    //public int Id { get; set; }
    public string Name { get; set; } = null!;
}
