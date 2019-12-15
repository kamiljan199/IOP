using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.DTOs;
using Api.Enums;
using Model.ViewModels;

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

        
    }
}

