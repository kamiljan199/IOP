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
        public void CreateVehicle(Vehicle vehicle);
        public void ChangeDriver(Vehicle vehicle, int driverID);
    }
}
