using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Data.Context;
using Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace Api.Managers
{
    public class ParcelManager : IParcelManager
    {
        private readonly AppDbContext _context;

        public ParcelManager(AppDbContext context)
        {
            _context = context;
        }

        public Parcel GetById(int id)
        {
            return _context.Parcels.FirstOrDefault(e => e.Id.Equals(id));
        }
        public Parcel GetByReferenceId(int id)
        {
            return _context.Parcels.FirstOrDefault(e => e.ReferenceId.Equals(id));
        }

        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace)
        {
            var query = from e in _context.Parcels
                        where e.StorePlaceId == storePlace.Id
                        select e;
            return query.ToArray();
        }

        public Parcel[] GetParcelsByStorePlaceWithAddress(StorePlace storePlace)
        {
            var query = from e in _context.Parcels
                        where e.StorePlaceId == storePlace.Id
                        select e;
            return query.Include(e => e.ReceiverData.PersonalAddress).
                Include(e => e.SenderData.PersonalAddress).ToArray();
        }

        public Parcel[] GetParcelsFromStorePlaceByStatus(StorePlace storePlace, ParcelStatus status)
        {
            return _context.Parcels.AsNoTracking()
                .Where(p => p.StorePlaceId == storePlace.Id && p.ParcelStatus == status)
               .Include(p => p.ReceiverData)
               .ThenInclude(p => p.PersonalAddress)
               .ToArray();
        }

        public Parcel[] GetAllParcels()
        {
            var query = from e in _context.Parcels
                        select e;
            return query.ToArray();
        }

        public int PostParcel(Parcel newParcel)
        {
            _context.Parcels.Add(newParcel);
            return _context.SaveChanges();
        }

        public int ChangeParcelPriority(Parcel parcelToChange, int priority)
        {
            Parcel parcel = _context.Parcels.Find(parcelToChange);
            if (parcel != null)
            {
                parcel.Priority = priority;
                _context.Parcels.Update(parcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status)
        {
            Parcel parcel = _context.Parcels.Find(parcelToChange.Id);
            if (parcel != null)
            {
                parcel.ParcelStatus = status;
                _context.Parcels.Update(parcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        public int ChangeParcelStorePlace(Parcel parcelToChange, int storePlaceID)
        {
            Parcel parcel = _context.Parcels.Find(parcelToChange.Id);
            if (parcel != null)
            {
                parcel.StorePlaceId = storePlaceID;
                _context.Parcels.Update(parcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int ReturnParcel(Parcel oldParcel)
        {
            Parcel parcelToReturn = _context.Parcels
                .Include(p => p.ReceiverData)
                    .ThenInclude(d => d.PersonalAddress)
                .Include(p => p.SenderData)
                    .ThenInclude(d => d.PersonalAddress)
                .Where(p => p.Id == oldParcel.Id)
                .FirstOrDefault();
            if (parcelToReturn != default(Parcel))
            {
                parcelToReturn.ParcelStatus = ParcelStatus.Returned;
                _context.Parcels.Update(parcelToReturn);

                Parcel newReturnParcel = new Parcel
                {
                    ReferenceId = parcelToReturn.Id,
                    ReceiverData = parcelToReturn.SenderData,
                    SenderData = parcelToReturn.ReceiverData,
                    StorePlaceId = parcelToReturn.StorePlaceId,
                    ParcelWidth = parcelToReturn.ParcelWidth,
                    ParcelLength = parcelToReturn.ParcelLength,
                    ParcelHeight = parcelToReturn.ParcelHeight,
                    Priority = parcelToReturn.Priority,
                    ParcelType = parcelToReturn.ParcelType,
                    ParcelStatus = ParcelStatus.InWarehouse
                };
                _context.Parcels.Add(newReturnParcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int SetCourierId(Parcel parcelToChange, int? courierId)
        {
            Parcel parcel = _context.Parcels.Find(parcelToChange.Id);
            if (parcel != null)
            {
                parcel.CourierID = courierId;
                _context.Parcels.Update(parcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateParcelCost(Parcel parcel)
        {
            decimal cost = 0;

            // Took the criteria from official DHL site
            float edgeSum = Math.Min(parcel.ParcelHeight, Math.Min(parcel.ParcelLength, parcel.ParcelWidth)) +
                            Math.Max(parcel.ParcelHeight, Math.Max(parcel.ParcelLength, parcel.ParcelWidth));
            if (edgeSum < 35.0 && parcel.ParcelWeight < 1.0)
            {
                cost = 16.90M;
            }
            else if (edgeSum < 75.0 && parcel.ParcelWeight < 10.0)
            {
                cost = 19.90M;
            }
            else if (edgeSum < 180.0 && parcel.ParcelWeight < 31.5)
            {
                cost = 29.90M;
            }

            return cost;
        }
    }
}
