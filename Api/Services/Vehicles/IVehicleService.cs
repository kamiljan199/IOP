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
        public void CreateVehicle(Vehicle vehicle);
        public void ChangeDriver(int vehicleID, Employee driver);
        
    }
}
