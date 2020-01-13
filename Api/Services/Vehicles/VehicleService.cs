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
        public void ChangeDriver(int vehicleID, Employee driver)
        {
            _vehicleManager.ChangeDriver(vehicleID, driver);
            var rowsChange = _vehicleManager.SaveChanges();
            if (rowsChange != 1)
            {
                throw new Exception();
            }
        }

        public Vehicle GetVehicleByID(int vehicleID)
        {
            return _vehicleManager.GetVehicleByID(vehicleID);
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            _vehicleManager.AddVehicle(vehicle);
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

        public void RemoveVehicle(Vehicle vehicle)
        {
            _vehicleManager.RemoveVehicle(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _vehicleManager.UpdateVehicle(vehicle);
        }
    }
}
