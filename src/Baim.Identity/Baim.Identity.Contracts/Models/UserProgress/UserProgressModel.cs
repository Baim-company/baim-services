namespace Baim.Identity.Contracts.Models.UserProgress;

public class UserProgressModel
{
    public Guid UserId { get; set; }

    public ushort CurrentStep { get; set; }

    public PersonalInfoModel? PersonalInfo { get; set; }

    public string? PasswordHash { get; set; }

    public CompanyInfoModel? CompanyInfo { get; set; }

    public ICollection<InvitedUserModel>? InvitedPeople { get; set; }

    public DateTime LastUpdated { get; set; }
}
