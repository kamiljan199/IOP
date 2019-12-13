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
                    entity
                        .Property(e => e.SenderName)
                        .HasMaxLength(50);
                    entity
                        .Property(e => e.ReceiverName)
                        .HasMaxLength(50);
                });
        }
    }
}
