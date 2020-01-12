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
        private readonly IEmployeeService _employeeService;
        public VehicleController(IVehicleService vehicleService, IEmployeeService employeeService)
        {
            _vehicleService = vehicleService;
            _employeeService = employeeService;
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

        public void CreateVehicle(string brand, string model, string registation)
        {
            var vehicle = new Vehicle
            {
                Brand = brand,
                Model = model,
                Registration = registation
            };

            _vehicleService.CreateVehicle(vehicle);
        }

        public void ChangeDriver(int vehicleID, int driverID)
        {
            //_vehicleService.ChangeDriver(_vehicleService.GetVehicleByID(vehicleID), _employeeService.GetEmployeeById(driverID));
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicleService.CreateVehicle(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            _vehicleService.RemoveVehicle(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _vehicleService.UpdateVehicle(vehicle);
        }
    }
}

