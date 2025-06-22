using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class UserProgressConfiguration : IEntityTypeConfiguration<UserProgress>
{
    public void Configure(EntityTypeBuilder<UserProgress> builder)
    {
        builder.ToTable("UserProgresses");

        builder.HasKey(u => u.UserId);

        builder.HasOne(up => up.PersonalInfo)
                .WithOne(pi => pi.UserProgress)
                .HasForeignKey<PersonalInfo>(pi => pi.UserProgressId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(up => up.CompanyInfo)
            .WithOne(ci => ci.UserProgress)
            .HasForeignKey<CompanyInfo>(ci => ci.UserProgressId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(up => up.InvitedUsers)
            .WithOne(iu => iu.UserProgress)
            .HasForeignKey(iu => iu.UserProgressId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(u => u.PasswordHash);
        builder.Property(u => u.CurrentStep);
        builder.Property(u => u.LastUpdated).IsRequired();
    }
}
