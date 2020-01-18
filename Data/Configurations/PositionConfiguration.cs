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

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    Id = 1,
                    Name = "Administrator",
                    MinSalary = 5000,
                    MaxSalary = 25000
                },
                new Position
                {
                    Id = 2,
                    Name = "HR",
                    MinSalary = 500,
                    MaxSalary = 1000
                },
                new Position
                {
                    Id = 3,
                    Name = "Kurier",
                    MinSalary = 1500,
                    MaxSalary = 2000
                },
                new Position
                {
                    Id = 4,
                    Name = "Logistyk",
                    MinSalary = 2500,
                    MaxSalary = 3000
                },
                new Position
                {
                    Id = 5,
                    Name = "Magazynier",
                    MinSalary = 1500,
                    MaxSalary = 1800
                },
                new Position
                {
                    Id = 6,
                    Name = "Rejestracja",
                    MinSalary = 1200,
                    MaxSalary = 1800
                }
            );
        }
    }
}
