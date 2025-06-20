namespace Baim.Identity.Data.Entities;

public class ActivityType
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public Guid CompanyInfoId { get; set; }
    public CompanyInfo CompanyInfo { get; set; }
}
