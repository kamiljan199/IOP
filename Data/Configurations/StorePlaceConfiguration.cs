using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class StorePlaceConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<StorePlace>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                    entity
                        .HasDiscriminator<int>(e => e.Type)
                        .HasValue<Warehouse>(0)
                        .HasValue<SendingPoint>(1)
                        .HasValue<StorePlace>(2);
                });
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
        }
    }
}
