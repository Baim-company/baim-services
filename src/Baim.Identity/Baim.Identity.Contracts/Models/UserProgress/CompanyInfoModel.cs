using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Models.UserProgress;

public class CompanyInfoModel
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string Voen { get; set; }
    public string LegalForm { get; set; }
    public string LegalAddress { get; set; }
    public string LegalRepresentative { get; set; }

    public string LogoImagePath { get; set; }

    public bool IsNational { get; set; }

    public List<ActivityTypeModel>? ActivityTypes { get; set; } = [];
}
