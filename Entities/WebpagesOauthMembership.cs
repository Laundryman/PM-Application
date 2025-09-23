namespace PMApplication.Entities;

public partial class WebpagesOauthMembership
{
    public string Provider { get; set; } = null!;

    public string ProviderUserId { get; set; } = null!;

    public int UserId { get; set; }
}
