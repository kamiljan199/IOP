using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IVehicleManager
    {
        public Vehicle GetVehicleByID(int vehicleID);
        public Vehicle GetVehicleByDriverID(int driverID);
        public void AddVehicle(string brand, string model, string registration);
        public void ChangeDriver(Vehicle vehicle, int driverID);
        public List<Vehicle> GetAllVehicles();

    }
}
