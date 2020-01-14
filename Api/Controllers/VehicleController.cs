using System;
using System.Collections.Generic;
using Api.Services;
using Api.DTOs;
using Api.Enums;
using Model.Models;

namespace Api.Controllers
{
    public class VehicleController
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public VehiclesDTO GetAllVehicles()
        {
            try
            {
                var vehiclesList = _vehicleService.GetAllVehicles();

                var result = new VehiclesDTO
                {
                    Vehicles = vehiclesList,
                    Status = CollectionGetStatus.Success

                };

                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                var result = new VehiclesDTO
                {
                    Status = CollectionGetStatus.Failure
                };

                return result;
            }
        }

        public void AddVehicle(Vehicle vehicle, bool detach = false)
        {
            _vehicleService.CreateVehicle(vehicle, detach);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            _vehicleService.RemoveVehicle(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _vehicleService.UpdateVehicle(vehicle);
        }

        public Vehicle GetVehicleById(int id)
        {
            return _vehicleService.GetVehicleByID(id);
        }
    }
}

