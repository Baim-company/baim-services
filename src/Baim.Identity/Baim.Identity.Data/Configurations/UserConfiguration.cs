using Baim.Identity.Contracts.Enums;
using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Surname).HasMaxLength(100);
        builder.Property(u => u.Patronymic).HasMaxLength(100);
        builder.Property(u => u.Position).HasMaxLength(150);
        builder.Property(u => u.BirthDate).IsRequired();
        builder.Property(u => u.Gender).IsRequired()
            .HasConversion(v => v.ToString(),v => (Gender)Enum.Parse(typeof(Gender), v));
        
        builder.Property(u => u.PersonalEmail).HasMaxLength(80);
        builder.Property(u => u.PhoneNumber).HasMaxLength(80);
        builder.Property(u => u.BusinessPhoneNumber).HasMaxLength(80);

        builder.Property(u => u.RefreshToken);
        builder.Property(u => u.RefreshTokenCreatedAt);
        builder.Property(u => u.RefreshTokenExpiryTime);

        builder.Property(u => u.HasCompletedSurvey).IsRequired().HasDefaultValue(false);

        builder.Property(u => u.AvatarPath).HasDefaultValue("user-icon.png");

        builder.HasMany(u => u.UserRoles)
            .WithOne(ur => ur.User)
            .HasForeignKey(ur => ur.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
