using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Api.Services;
using Api.DTOs;
using Model.Models;

namespace Api.Controllers
{
    public class RouteController
    {
        private readonly IRouteService _routeService;
        private readonly IParcelService _parcelService;

        public RouteController(IRouteService routeService, IParcelService parcelService)
        {
            _routeService = routeService;
            _parcelService = parcelService;
        }

        public NewRouteDTO CreateRoute(int driverId, int carId, int[] parcelIds)
        {
            NewRouteDTO dto;

            try
            {
                Route route = _routeService.CreateRoute(driverId, carId, parcelIds);

                foreach (RoutePoint point in route.RoutePoints)
                {
                    _parcelService.ChangeParcelStatus(point.Parcel, Model.Enums.ParcelStatus.OnWayToTheCustomer);
                }
                dto = new NewRouteDTO()
                {
                    Route = route,
                    Status = Enums.NewRouteStatus.Success
                };
            }
            catch (Exception ex)
            {
                dto = new NewRouteDTO()
                {
                    ErrorMessage = ex.Message,
                    Status = Enums.NewRouteStatus.Failure
                };
            }

            return dto;
        }

        public RoutesDTO GetAllRoutes()
        {
            RoutesDTO dto;
            try
            {
                var routes = _routeService.GetAllRoutes();
                dto = new RoutesDTO
                {
                    Routes = routes,
                    Status = routes.Length == 0 ? Enums.CollectionGetStatus.Empty : Enums.CollectionGetStatus.Success
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                dto = new RoutesDTO
                {
                    Status = Enums.CollectionGetStatus.Failure
                };
            }
            return dto;
        }

        public RoutesDTO GetRouteById(int id)
        {
            RoutesDTO dto;
            try
            {
                var route = _routeService.GetRouteByID(id);
                dto = new RoutesDTO
                {
                    Routes = new [] { route },
                    Status = route == default(Route) ? Enums.CollectionGetStatus.Empty : Enums.CollectionGetStatus.Success
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                dto = new RoutesDTO
                {
                    Status = Enums.CollectionGetStatus.Failure
                };
            }
            return dto;
        }
    }
}
