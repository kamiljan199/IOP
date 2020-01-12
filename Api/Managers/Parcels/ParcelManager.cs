using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Data.Context;
using Model.Enums;

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
            Parcel parcel = _context.Parcels.Find(parcelToChange);
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

        public int ReturnParcel(Parcel oldParcel)
        {
            Parcel parcelToReturn = _context.Parcels.Find(oldParcel);
            if (parcelToReturn != null)
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
                    ParcelStatus = ParcelStatus.OnWayToWarehouse
                };
                _context.Parcels.Add(newReturnParcel);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
