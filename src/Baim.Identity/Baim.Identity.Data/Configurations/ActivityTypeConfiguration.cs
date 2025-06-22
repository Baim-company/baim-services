using Baim.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Baim.Identity.Data.Configurations;

public class ActivityTypeConfiguration : IEntityTypeConfiguration<ActivityType>
{
    public void Configure(EntityTypeBuilder<ActivityType> builder)
    {
        builder.ToTable("ActivityTypes");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Title).IsRequired().HasMaxLength(200);

        builder.HasOne<CompanyInfo>()
            .WithMany(ci => ci.ActivityTypes)
            .HasForeignKey(at => at.CompanyInfoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
