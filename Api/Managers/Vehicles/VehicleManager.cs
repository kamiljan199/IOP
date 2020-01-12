using System;
using System.Collections.Generic;
using Model.Models;
using System.Linq;
using Data.Context;

namespace Api.Managers
{
    public class VehicleManager : IVehicleManager
    {
        private AppDbContext _context;
        public VehicleManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void ChangeDriver(int vehicleID, Employee driver)
        {
            GetVehicleByID(vehicleID).Driver = driver;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle GetVehicleByDriverID(int driverID)
        {
            return _context.Vehicles.FirstOrDefault(e => e.Driver.Id.Equals(driverID));
        }

        public Vehicle GetVehicleByID(int vehicleID)
        {
            return _context.Vehicles.FirstOrDefault(e => e.Id.Equals(vehicleID));
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();
        }
    }
}
