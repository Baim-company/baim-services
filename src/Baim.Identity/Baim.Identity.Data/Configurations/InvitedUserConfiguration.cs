using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class InvitedUserConfiguration : IEntityTypeConfiguration<InvitedUser>
{
    public void Configure(EntityTypeBuilder<InvitedUser> builder)
    {
        builder.ToTable("InvitedUsers");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Surname).IsRequired().HasMaxLength(100);

        builder.HasOne<UserProgress>()
            .WithMany()
            .HasForeignKey(iu => iu.UserProgressId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
