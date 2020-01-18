using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class EmploymentConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Employment>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                });
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employment>().HasData(
                new Employment
                {
                    Id = 1,
                    StartDate = new System.DateTime(),
                    Salary = 20000,
                    IsActive = true,
                    PositionId = 1,
                    EmployeeId = 1
                }
            );
        }
    }
}
