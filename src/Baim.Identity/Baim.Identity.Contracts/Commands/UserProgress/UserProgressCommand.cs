using Baim.Identity.Contracts.Models.UserProgress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Commands.UserProgress;

public class UserProgressCommand
{
    public PersonalInfoModel? PersonalInfoModel { get; set; }

    public string? Password { get; set; }

    public CompanyInfoModel? CompanyInfoModel { get; set; }

    public List<InvitedUserModel>? InvitePeopleModel { get; set; }
}
