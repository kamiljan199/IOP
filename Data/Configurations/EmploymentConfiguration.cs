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
                },

                new Employment
                {
                    Id = 2,
                    StartDate = new System.DateTime(),
                    Salary = 950,
                    IsActive = true,
                    PositionId = 2,
                    EmployeeId = 2
                },

                new Employment
                {
                    Id = 3,
                    StartDate = new System.DateTime(),
                    Salary = 1600,
                    IsActive = true,
                    PositionId = 3,
                    EmployeeId = 3,
                    StorePlaceId = 1
                },

                new Employment
                {
                    Id = 4,
                    StartDate = new System.DateTime(),
                    Salary = 2800,
                    IsActive = true,
                    PositionId = 4,
                    EmployeeId = 4
                },

                new Employment
                {
                    Id = 5,
                    StartDate = new System.DateTime(),
                    Salary = 1750,
                    IsActive = true,
                    PositionId = 5,
                    EmployeeId = 5,
                    StorePlaceId = 1
                    
                },

                new Employment
                {
                    Id = 6,
                    StartDate = new System.DateTime(),
                    Salary = 1300,
                    IsActive = true,
                    PositionId = 6,
                    EmployeeId = 6,
                    StorePlaceId = 2
                },

                new Employment
                {
                    Id = 7,
                    StartDate = new System.DateTime(),
                    Salary = 1700,
                    IsActive = true,
                    PositionId = 3,
                    EmployeeId = 7,
                    StorePlaceId = 2
                }
            );
        }
    }
}
