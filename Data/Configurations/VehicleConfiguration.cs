using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class VehicleConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Vehicle>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                    entity
                        .Property(e => e.Brand)
                        .HasMaxLength(20);
                    entity
                        .Property(e => e.Model)
                        .HasMaxLength(20);
                    entity
                        .Property(e => e.Registration)
                        .HasMaxLength(15);
                    
                });
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            
        }
    }
}
