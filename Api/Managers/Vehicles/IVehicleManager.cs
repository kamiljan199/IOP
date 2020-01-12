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
        public void AddVehicle(Vehicle vehicle);
        public void ChangeDriver(int vehicleID, Employee driver);
        public List<Vehicle> GetAllVehicles();
        public int SaveChanges();

        public void RemoveVehicle(Vehicle vehicle);
    }
}
