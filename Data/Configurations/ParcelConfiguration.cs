using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class ParcelConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Parcel>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                });
        }
    }
}
