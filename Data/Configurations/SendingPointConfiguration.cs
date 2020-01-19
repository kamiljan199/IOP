using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class SendingPointConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SendingPoint>()
                .HasBaseType<StorePlace>();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SendingPoint>().HasData(
                new SendingPoint
                {
                    Id = 2,
                    Name = "Magazyn",
                    WorkersCount = 2,
                    AddressId = 2
                }
            );

        }
    }
}
