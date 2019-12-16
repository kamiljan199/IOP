using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class PositionConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Position>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                    entity
                        .Property(e => e.Name)
                        .HasMaxLength(20);
                });
        }
    }
}
