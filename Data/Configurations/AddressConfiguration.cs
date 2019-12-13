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
                });
        }
    }
}
