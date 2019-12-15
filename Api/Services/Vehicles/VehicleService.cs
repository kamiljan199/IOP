using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public class VehicleService : IVehicleService
    {
        private IVehicleManager _vehicleManager;
        public VehicleService(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }
        public void ChangeDriver(Vehicle vehicle, int driverID)
        {
            _vehicleManager.ChangeDriver(vehicle, driverID);
        }

        public void CreateVehicle(string brand, string model, string registration)
        {
            _vehicleManager.AddVehicle(brand, model, registration);
        }

        public List<Vehicle> GetAllVehicles()
        {
            var vehiclesList = _vehicleManager.GetAllVehicles();
            if (vehiclesList.Count.Equals(0))
            {
                throw new Exception($"No vehicle has been found");
            }
            return vehiclesList;
        }
    }
}
