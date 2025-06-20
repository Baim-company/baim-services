using Baim.Identity.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Models.User;

public class UserModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }

    public string Role { get; set; }
    public Gender Gender { get; set; }
    public string Position { get; set; }
    public string AvatarPath { get; set; }
    public DateTime BirthDate { get; set; }

    public string Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PersonalEmail { get; set; }

    public string PhoneNumber { get; set; }
    public string BusinessPhoneNumber { get; set; }
    public bool HasCompletedSurvey { get; set; }
}
