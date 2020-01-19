using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Context;
using Model.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Model.Models.Exceptions;

namespace Api.Managers
{
    public class RouteManager : IRouteManager
    {
        private readonly AppDbContext _context;

        public RouteManager(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Route route, RoutePoint[] routePoints)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Routes.Add(route);
                if (_context.SaveChanges() == 0)
                {
                    transaction.Rollback();
                    throw new NothingAddedToDatabaseException(route);
                }

                foreach (RoutePoint point in routePoints)
                    point.RouteId = route.Id;

                _context.RoutePoints.AddRange(routePoints);
                if (_context.SaveChanges() < routePoints.Length)
                {
                    transaction.Rollback();
                    throw new NothingAddedToDatabaseException(routePoints);
                }

                transaction.Commit();
                return route.Id;
            }
        }

        public Route GetRouteByID(int id)
        {
            var route = _context.Routes.AsNoTracking()
                .Where(r => r.Id.Equals(id))
                .Include(r => r.Employee)
                .Include(r => r.Vehicle)
                .FirstOrDefault();
            if (route != default(Route))
            {
                route.RoutePoints = _context.RoutePoints.AsNoTracking()
                    .Where(p => p.RouteId.Equals(id))
                    .Include(p => p.Parcel)
                        .ThenInclude(parcel => parcel.ReceiverData)
                            .ThenInclude(personalData => personalData.PersonalAddress)
                    .Include(p => p.Parcel)
                        .ThenInclude(parcel => parcel.SenderData)
                            .ThenInclude(personalData => personalData.PersonalAddress)
                    .OrderBy(p => p.Index)
                    .ToList();
            }
            return route;
        }

        public Route[] GetAllRoutes()
        {
            return _context.Routes.AsNoTracking()
                .Include(r => r.Employee)
                .Include(r => r.Vehicle)
                .ToArray();
        }
    }
}
