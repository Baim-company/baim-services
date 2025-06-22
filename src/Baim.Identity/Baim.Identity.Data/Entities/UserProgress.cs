namespace Baim.Identity.Data.Entities;

public class UserProgress
{
    public Guid UserId { get; set; }

    public ushort CurrentStep { get; set; }

    public Guid? PersonalInfoId { get; set; }
    public PersonalInfo? PersonalInfo { get; set; }

    public string? PasswordHash { get; set; }


    public Guid? CompanyInfoId { get; set; }
    public CompanyInfo? CompanyInfo { get; set; }

    public ICollection<InvitedUser>? InvitedUsers { get; set; }

    public DateTime LastUpdated { get; set; }
}
