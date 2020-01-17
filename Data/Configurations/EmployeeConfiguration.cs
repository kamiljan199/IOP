using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class EmployeeConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Employee>(entity =>
                {
                    entity
                        .HasKey(e => e.Id);
                    entity
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();
                    entity
                        .Property(e => e.Name)
                        .HasMaxLength(20);
                    entity
                        .Property(e => e.Surname)
                        .HasMaxLength(50);
                    entity
                        .Property(e => e.Pesel)
                        .HasMaxLength(11)
                        .IsFixedLength();
                    /*
                    entity
                        .HasOne(e => e.ActiveEmployment)
                        .WithOne(e => e.Employee)
                        .HasForeignKey<Employee>(e => e.EmploymentId);
                        */
                });
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            
        }
    }
}
