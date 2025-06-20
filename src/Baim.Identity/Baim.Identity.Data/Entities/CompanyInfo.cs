namespace Baim.Identity.Data.Entities;

public class CompanyInfo
{
    public Guid Id { get; set; }

    public string CompanyName { get; set; }
    public string Voen { get; set; }
    public string LegalForm { get; set; }
    public string LegalAddress { get; set; }
    public string LegalRepresentative { get; set; }

    public string LogoImagePath { get; set; }

    public bool IsNational { get; set; }

    public ICollection<ActivityType> ActivityTypes { get; set; }


    public Guid UserProgressId { get; set; }
    public UserProgress UserProgress { get; set; }
}