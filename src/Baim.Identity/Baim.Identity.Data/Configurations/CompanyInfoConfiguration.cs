using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class CompanyInfoConfiguration : IEntityTypeConfiguration<CompanyInfo>
{
    public void Configure(EntityTypeBuilder<CompanyInfo> builder)
    {
        builder.ToTable("CompanyInfos");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.CompanyName).IsRequired().HasMaxLength(200);
        builder.HasIndex(u => u.CompanyName).IsUnique();

        builder.Property(u => u.Voen).IsRequired().HasMaxLength(30);
        builder.Property(u => u.LegalForm).IsRequired().HasMaxLength(250);
        builder.Property(u => u.LegalAddress).IsRequired().HasMaxLength(250);
        builder.Property(u => u.LegalRepresentative).IsRequired().HasMaxLength(250);

        builder.Property(u => u.IsNational).IsRequired();
        builder.Property(u => u.LogoImagePath).IsRequired().HasDefaultValue("company-default-icon.png");

        builder.HasMany(x => x.ActivityTypes)
                .WithOne(x => x.CompanyInfo)
                .HasForeignKey(x => x.CompanyInfoId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<UserProgress>()
            .WithOne(up => up.CompanyInfo)
            .HasForeignKey<CompanyInfo>(ci => ci.UserProgressId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
