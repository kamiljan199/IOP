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
        private readonly IList<IEntityConfiguration> _entityConfigurations = new List<IEntityConfiguration>
        {
            new PersonalDataConfiguration(),
            new ParcelConfiguration(),
            new StorePlaceConfiguration(),
            new WarehouseConfiguration(),
            new SendingPointConfiguration(),
            new AddressConfiguration(),
            new EmployeeConfiguration(),
            new EmploymentConfiguration(),
            new PositionConfiguration(),
            new VehicleConfiguration(),
            new RouteConfiguration(),
            new RoutePointConfiguration()
        };

        public AppDbContext() : base()
        {
            
        }
        
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            //Configuration = configuration;
        }

        public virtual DbSet<Parcel> Parcels { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<StorePlace> StorePlaces { get; set; }
        public virtual DbSet<PersonalData> PersonalDatas { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RoutePoint> RoutePoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(Configuration.GetConnectionString("localhost"));
            //optionsBuilder.UseMySql("server=localhost;database=iop;uid=root;pwd=;");

            //optionsBuilder.UseMySql(Configuration.GetConnectionString("db4free.net"));
            //optionsBuilder.UseMySql("server=db4free.net;database=pawelkun1;uid=pawelkun1;pwd=k44wy3p51;");

            //optionsBuilder.UseMySql(Configuration.GetConnectionString("bartek"));
            optionsBuilder.UseMySql("server=136.243.132.217;database=bartek97_io;uid=bartek97_io;pwd=1(CI1(33)d3G@e_;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var configuration in _entityConfigurations)
            {
                configuration.AddConfiguration(modelBuilder);
                configuration.SeedData(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
