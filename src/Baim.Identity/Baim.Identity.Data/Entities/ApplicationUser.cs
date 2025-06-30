using Baim.Identity.Contracts.Enums;
using Microsoft.AspNetCore.Identity;

namespace Baim.Identity.Data.Entities;

public class ApplicationUser: IdentityUser<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }

    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
    public string Position { get; set; }


    public string PersonalEmail { get; set; }
    public string BusinessPhoneNumber { get; set; }


    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public DateTime RefreshTokenCreatedAt { get; set; }

    public string AvatarPath { get; set; }
    public bool HasCompletedSurvey { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}
