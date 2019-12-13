using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Models;
using Data.Configurations;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        //private readonly IConfiguration Configuration;
        private readonly IList<IEntityConfiguration> _entityConfigurations;

        public AppDbContext() : base()
        {
            _entityConfigurations = new List<IEntityConfiguration>
            {
                new ParcelConfiguration(),
                new StorePlaceConfiguration(),
                new WarehouseConfiguration(),
                new SendingPointConfiguration(),
                new AddressConfiguration()
            };
        }
        
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            //Configuration = configuration;
            
            _entityConfigurations = new List<IEntityConfiguration>
            {
                new ParcelConfiguration(),
                new StorePlaceConfiguration(),
                new WarehouseConfiguration(),
                new SendingPointConfiguration(),
                new AddressConfiguration()
            };
        }

        public virtual DbSet<Parcel> Parcels { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<StorePlace> StorePlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(Configuration.GetConnectionString("MySQL"));
            optionsBuilder.UseMySql("server=localhost;database=iop;uid=root;pwd=;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var configuration in _entityConfigurations)
            {
                configuration.AddConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
