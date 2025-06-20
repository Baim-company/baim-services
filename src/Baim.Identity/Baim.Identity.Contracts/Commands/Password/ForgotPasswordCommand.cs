using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Commands.Password;

public class ForgotPasswordCommand
{
    public string Email { get; set; }
}
