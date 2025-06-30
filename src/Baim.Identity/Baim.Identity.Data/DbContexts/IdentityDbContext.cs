using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Baim.Identity.Data.DbContexts;

public class IdentityDbContext : DbContext
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options): base(options) { }

    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<ApplicationRole> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }

    public DbSet<ActivityType> ActivityTypes { get; set; }
    public DbSet<CompanyInfo> CompanyInfos { get; set; }
    public DbSet<PersonalInfo> PersonalInfos { get; set; }
    public DbSet<InvitedUser> InvitedUsers { get; set; }
    public DbSet<UserProgress> UserProgresses { get; set; }

    public DbSet<PasswordResetToken> PasswordResetTokens { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
    }
}
