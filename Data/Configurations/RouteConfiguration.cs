using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class RouteConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Route>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                });

            modelBuilder.Entity<Route>()
                .HasMany(p => p.RoutePoints)
                .WithOne(r => r.Route)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            
        }
    }
}
