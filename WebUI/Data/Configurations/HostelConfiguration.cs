using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebUI.Models;

namespace WebUI.Data.Configurations
{
    public class HostelConfiguration : IEntityTypeConfiguration<Hostel>
    {
        public void Configure(EntityTypeBuilder<Hostel> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(14);
            builder.Property(b => b.Flooring).HasMaxLength(200);
            builder.Property(b => b.Capacity).HasMaxLength(200);
            builder.Property(b => b.LivingRoomCount).HasMaxLength(200);
            builder.Property(b => b.ServiceRoomCount).HasMaxLength(200);
            builder.Property(b => b.OfficeRoomCount).HasMaxLength(200);
        }
    }
}