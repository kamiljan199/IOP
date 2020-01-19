using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Api.Managers;
using Model.Models;
using Api.Helpers;
using Model.Models.Exceptions;

namespace Api.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteManager _routeManager;
        private readonly IVehicleManager _vehicleManager;
        private readonly IEmployeeManager _employeeManager;
        private readonly IParcelManager _parcelManager;

        public RouteService(
            IRouteManager routeManager,
            IVehicleManager vehicleManager,
            IEmployeeManager employeeManager,
            IParcelManager parcelManager
            )
        {
            _routeManager = routeManager;
            _vehicleManager = vehicleManager;
            _employeeManager = employeeManager;
            _parcelManager = parcelManager;
        }

        public Route CreateRoute(int driverId, int carId, int[] parcelIds)
        {
            Employee driver = _employeeManager.GetEmployeeById(driverId);
            if (driver == default(Employee))
                throw new NewRouteInvalidDataException(new Employee());

            Vehicle car = _vehicleManager.GetVehicleByID(carId);
            if (car == default(Vehicle))
                throw new NewRouteInvalidDataException(new Vehicle());

            // parcel ids in array are already in delviery order
            List<Parcel> parcels = new List<Parcel>();
            foreach (int pid in parcelIds)
            {
                Parcel parcel = _parcelManager.GetById(pid);
                if (parcel == default(Parcel))
                    throw new NewRouteInvalidDataException(new Parcel());
                if (parcel.ParcelStatus != Model.Enums.ParcelStatus.InWarehouse)
                    throw new NewRouteInvalidDataException(parcel.ParcelStatus);
                parcels.Add(parcel);
            }

            CargoDetails cargoDetails = CalculateCargoDetails(car, parcels.ToArray());
            if (cargoDetails.IsOverloaded())
                throw new OverloadedCargoForRouteException();


            Route route = new Route()
            {
                EmployeeId = driver.Id,
                VehicleId = car.Id,
                CreationDateTime = DateTime.Now
            };
            List<RoutePoint> routePoints = new List<RoutePoint>();
            int index = 1;
            foreach (Parcel parcel in parcels)
            {
                routePoints.Add(new RoutePoint()
                {
                        ParcelId = parcel.Id,
                        Index = index++
                });
            }

            int newRouteId = _routeManager.Add(route, routePoints.ToArray());
            return GetRouteByID(newRouteId);
        }

        public Route GetRouteByID(int id) => _routeManager.GetRouteByID(id);
        public Route[] GetAllRoutes() => _routeManager.GetAllRoutes();

        public CargoDetails CalculateCargoDetails(Vehicle car, Parcel[] parcels)
        {
            double maxWeight = car.MaxLoad;
            double maxVolume = car.MaxCapacity;
            double totalWeight = 0, totalVolume = 0;
            foreach (Parcel parcel in parcels)
            {
                totalWeight += parcel.ParcelWeight;
                totalVolume += parcel.ParcelHeight * parcel.ParcelLength * parcel.ParcelWidth;
            }
            return new CargoDetails(totalWeight, maxWeight, totalVolume, maxVolume);
        }
    }
}
