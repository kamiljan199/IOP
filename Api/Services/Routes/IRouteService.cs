using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Api.Helpers;
using Model.Models;

namespace Api.Services
{
    public interface IRouteService
    {
        public Route CreateRoute(int driverId, int carId, int[] parcelIds);
        public Route GetRouteByID(int id);
        public Route[] GetAllRoutes();
        public CargoDetails CalculateCargoDetails(Vehicle car, Parcel[] parcels);
    }
}
