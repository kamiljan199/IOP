using Microsoft.EntityFrameworkCore;
using Model.Models;
namespace Data.Configurations
{
    class AddressConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Address>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                    entity
                        .Property(e => e.City)
                        .HasMaxLength(30);
                    entity
                        .Property(e => e.PostCode)
                        .HasMaxLength(15);
                    entity
                        .Property(e => e.Street)
                        .HasMaxLength(50);
                    entity
                        .Property(e => e.Number)
                        .HasMaxLength(30);
                });
        }
    }
}
