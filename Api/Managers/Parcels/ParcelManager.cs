using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Data.Context;

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

        public int ReturnParcel(Parcel oldParcel)
        {
            Parcel parcelToReturn = _context.Parcels.Find(oldParcel);
            if (parcelToReturn != null)
            {
                Parcel newReturnParcel = new Parcel(parcelToReturn);
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
