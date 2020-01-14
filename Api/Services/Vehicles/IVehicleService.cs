using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public interface IVehicleService
    {
        public List<Vehicle> GetAllVehicles();
        public Vehicle GetVehicleByID(int vehicleID);
        public void CreateVehicle(Vehicle vehicle, bool detach = false);
        public void RemoveVehicle(Vehicle vehicle);
        public void UpdateVehicle(Vehicle vehicle);
    }
}
