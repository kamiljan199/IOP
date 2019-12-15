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

        public void AddVehicle(string brand, string model, string registration)
        {
            throw new NotImplementedException();
        }

        public void ChangeDriver(Vehicle vehicle, int driverID)
        {
            throw new NotImplementedException();
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
    }
}
