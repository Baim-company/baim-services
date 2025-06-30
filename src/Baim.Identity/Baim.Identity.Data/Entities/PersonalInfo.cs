using Baim.Identity.Contracts.Enums;

namespace Baim.Identity.Data.Entities;

public class PersonalInfo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }

    public string Email { get; set; }
    public string PersonalEmail { get; set; }

    public string PhoneNumber { get; set; }
    public string BusinessPhoneNumber { get; set; }

    public string Position { get; set; }

    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }

    public string AvatarPath { get; set; }

    public Guid UserProgressId { get; set; }
    public UserProgress UserProgress { get; set; }
}
