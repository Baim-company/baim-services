using Microsoft.AspNetCore.Identity;

namespace Baim.Identity.Data.Entities;

public class ApplicationRole: IdentityRole<Guid>
{
    public string Description { get; set; }

    public ICollection<RolePermission> RolePermissions { get; set; }
}
