using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Models.UserProgress;

public class InvitedUserModel
{
    public string Email { get; init; }
    public string Name { get; init; }
    public string Surname { get; init; }
}
