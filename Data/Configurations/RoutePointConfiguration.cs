using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class RoutePointConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<RoutePoint>(entity =>
                {
                    entity
                        .HasKey(e => new { e.RouteId, e.Index });
                    entity
                        .HasIndex(e => e.RouteId);
                });

            modelBuilder.Entity<RoutePoint>()
                .HasOne(r => r.Route)
                .WithMany(p => p.RoutePoints);
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            
        }
    }
}
