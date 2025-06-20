using Baim.Identity.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Commands.Settings;

public class ChangeSettingsCommand
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    public string Position { get; set; }


    public string Email { get; set; }
    public string PersonalEmail { get; set; }


    public string PhoneNumber { get; set; }
    public string? BusinessPhoneNumber { get; set; }

    public Gender Gender { get; set; } = Gender.Man;
}
