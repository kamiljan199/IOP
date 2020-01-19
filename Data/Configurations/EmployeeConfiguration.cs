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
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mariusz",
                    Surname = "Pudzianowski",
                    Pesel = "EZG 34XD23",
                    Login = "admin",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1978, 3, 8)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Jan",
                    Surname = "Drzewski",
                    Pesel = "84110926511",
                    Login = "jan84",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1984, 11, 9)
                },

                new Employee
                {
                    Id = 3,
                    Name = "Patryk",
                    Surname = "Vege",
                    Pesel = "6584421212",
                    Login = "PolskiMichelBay",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1965, 12, 16)
                },

                new Employee
                {
                    Id = 4,
                    Name = "Ignacy",
                    Surname = "Luduba",
                    Pesel = "10040158425",
                    Login = "EeeexD",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(2010, 4, 1)
                },

                new Employee
                {
                    Id = 5,
                    Name = "Czcibor",
                    Surname = "Piast",
                    Pesel = "85101220686",
                    Login = "Tryglaw",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1985, 10, 12)
                },

                new Employee
                {
                    Id = 6,
                    Name = "Joanna",
                    Surname = "Sosna",
                    Pesel = "95050135841",
                    Login = "CoolSkeleton95",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1995, 5, 1)
                },

                new Employee
                {
                    Id = 7,
                    Name = "Janusz",
                    Surname = "Tracz",
                    Pesel = "73021164841",
                    Login = "YourBestNightmare",
                    Password = "0DPiKuNIrrVmD8IUCuw1hQxNqZc=",
                    Birthday = new System.DateTime(1973, 2, 11)
                }
            );
        }
    }
}
