using Baim.Identity.Contracts.Enums;
using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
{
    public void Configure(EntityTypeBuilder<PersonalInfo> builder)
    {
        builder.ToTable("PersonalInfos");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Surname).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Patronymic).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.PersonalEmail).HasMaxLength(80);
        builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(120);
        builder.Property(u => u.BusinessPhoneNumber).HasMaxLength(120);
        builder.Property(u => u.Position).IsRequired().HasMaxLength(150);
        builder.Property(u => u.BirthDate).IsRequired();
        builder.Property(u => u.Gender).IsRequired()
            .HasConversion(v => v.ToString(), v => (Gender)Enum.Parse(typeof(Gender), v));

        builder.Property(u => u.AvatarPath).IsRequired().HasDefaultValue("user-icon.png");

        builder.HasOne<UserProgress>()
            .WithOne(up => up.PersonalInfo)
            .HasForeignKey<PersonalInfo>(pi => pi.UserProgressId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
