using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Commands.Password;

public class ResetPasswordCommand
{
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string Token { get; set; }
}
