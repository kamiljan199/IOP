using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IVehicleManager
    {
        public Vehicle GetVehicleByID(int vehicleID);
        public void AddVehicle(Vehicle vehicle, bool detach = false);
        public List<Vehicle> GetAllVehicles();
        public int SaveChanges();
        public void RemoveVehicle(Vehicle vehicle);
        public void UpdateVehicle(Vehicle vehicle);
    }
}
