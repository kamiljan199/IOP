using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class WarehouseConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Warehouse>()
                .HasBaseType<StorePlace>();
            modelBuilder
                .Entity<Warehouse>(entity =>
                {
                    entity
                        .Property(e => e.ManagerName)
                        .HasMaxLength(50);
                });
        }
    }
}
