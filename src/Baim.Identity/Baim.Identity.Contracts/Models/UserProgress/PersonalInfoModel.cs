using Baim.Identity.Contracts.Enums;

namespace Baim.Identity.Contracts.Models.UserProgress;

public class PersonalInfoModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }

    public string PersonalEmail { get; set; }

    public string PhoneNumber { get; set; }
    public string? BusinessPhoneNumber { get; set; }

    public string Position { get; set; }

    public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    public Gender Gender { get; set; } = Gender.Man;

    public string AvatarPath { get; set; } = "user-icon.png";
}
