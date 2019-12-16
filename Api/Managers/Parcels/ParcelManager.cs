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

        public void PostParcel(Parcel newParcel)
        {
            if (_context.Parcels.Find(newParcel) != null)
            {
                _context.Parcels.Add(newParcel);
            }
            else
            {
                throw new Model.Models.Exceptions.ParcelAlreadyPresentInDatabase(newParcel);
            }
        }

        public void ReturnParcel(Parcel oldParcel)
        {
            Parcel parcelToReturn = _context.Parcels.Find(oldParcel);
            if (parcelToReturn != null)
            {
                Parcel newReturnParcel = new Parcel(parcelToReturn.StorePlaceId, parcelToReturn.SenderData, parcelToReturn.ReceiverData, parcelToReturn.Id);
                _context.Parcels.Add(newReturnParcel);
            }
            else
            {
                throw new Model.Models.Exceptions.ParcelNotFoundInDatabase(oldParcel);
            }
        }
    }
}
