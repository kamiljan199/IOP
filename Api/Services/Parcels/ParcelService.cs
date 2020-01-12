using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;
using Model.Models.Exceptions;

namespace Api.Services
{
    public class ParcelService : IParcelService
    {
        private readonly IParcelManager _parcelManager;

        public ParcelService(IParcelManager parcelManager)
        {
            _parcelManager = parcelManager;
        }

        public Parcel GetById(int id)
        {
            var parcel = _parcelManager.GetById(id);
            if(parcel == default(Parcel))
            {
                throw new ParcelNotFoundInDatabaseException(id);
            }

            return parcel;
        }

        public Parcel GetByReferenceId(int id)
        {
            var parcel = _parcelManager.GetByReferenceId(id);
            if (parcel == default(Parcel))
            {
                throw new ParcelNotFoundInDatabaseException(id);
            }

            return parcel;
        }

        public void PostParcel(Parcel newParcel)
        {
            if (_parcelManager.PostParcel(newParcel) == 0)
            {
                throw new NothingAddedToDatabaseException(newParcel);
            }
        }

        public void DeliverParcel(Parcel oldParcel)
        {
            if (_parcelManager.DeliverParcel(oldParcel) == 0)
            {
                throw new NothingAddedToDatabaseException(oldParcel);
            }
        }

        public void ReturnParcel(Parcel oldParcel)
        {
            if (_parcelManager.ReturnParcel(oldParcel) == 0)
            {
                throw new NothingAddedToDatabaseException(oldParcel);
            }
            
        }
    }
}
