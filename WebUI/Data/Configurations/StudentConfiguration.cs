using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebUI.Models;

namespace WebUI.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(b => b.RegionOrCityId).IsRequired();
            builder.HasOne(b => b.RegionOrCity).WithMany().HasForeignKey(b => b.RegionOrCityId);
            builder.Property(b => b.DistrictOrCityId).IsRequired();
            builder.HasOne(b => b.DistrictOrCity).WithMany().HasForeignKey(b => b.DistrictOrCityId);
            builder.HasOne(b => b.CountrysideOrCity).WithMany().HasForeignKey(b => b.CountrysideOrCityId);
            builder.HasOne(b => b.Village).WithMany().HasForeignKey(b => b.VillageId);
            builder.Property(b => b.Street).HasMaxLength(400);
            builder.Property(b => b.House).HasMaxLength(20);
            builder.Property(b => b.Flat).HasMaxLength(20);

        }
    }
}