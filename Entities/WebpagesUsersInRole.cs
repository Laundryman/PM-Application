namespace PMApplication.Entities;

public partial class WebpagesUsersInRole
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public virtual UserProfile User { get; set; } = null!;
}
