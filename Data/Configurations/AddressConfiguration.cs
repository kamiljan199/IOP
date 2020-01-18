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

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                new Address 
                { 
                    Id = 2137, 
                    City = "Wadowice", 
                    PostCode = "69-666", 
                    Street = "Papieżowa", 
                    HomeNumber = "JP2/GMD", 
                    ApartmentNumber = 420 
                },
                new Address
                {
                    Id = 666,
                    City = "Piekło",
                    PostCode = "66-666",
                    Street = "Ozzy'ego Osbourna",
                    HomeNumber = "666/666",
                    ApartmentNumber = 666
                },
                new Address
                {
                    Id = 1,
                    City = "Łuć",
                    Street = "Skrzywana",
                    PostCode = "98-205"
                },
                new Address
                {
                    Id = 2,
                    City = "Łuć",
                    Street = "Radwańska",
                    PostCode = "98-205"
                }
            );
        }
    }
}
