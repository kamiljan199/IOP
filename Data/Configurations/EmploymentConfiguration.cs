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
                    /*entity
                        .HasOne(e => e.Employee)
                        .WithOne(e => e.ActiveEmployment)
                        .HasForeignKey<Employment>(e => e.EmployeeId);
                        */
                });
        }
    }
}
