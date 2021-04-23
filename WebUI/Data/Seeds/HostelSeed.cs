using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Data.Seeds
{
    internal static class HostelSeed
    {
        internal static ModelBuilder AddHostelSeedData(this ModelBuilder builder)
        {
            var users = new Hostel[]
            {
                new Hostel
                {
                    Id = 1,
                    Name = "Общежитие №1",
                    Flooring = 4,
                    Capacity = "200",
                    LivingRoomCount = 158,
                    ServiceRoomCount = 12,
                    Map = "Общежитие №1",
                    OfficeRoomCount = 5,
                },
            };

            builder.Entity<Hostel>().HasData(users);

            return builder;
        }
    }
}