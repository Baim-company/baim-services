namespace Baim.Identity.Data.Entities;

public class UserRole
{
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; }

    public Guid RoleId { get; set; }
    public ApplicationRole Role { get; set; }
}
