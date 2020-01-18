using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Enums;
using Model.Models;
using Model.Models.Exceptions;

namespace Api.Services
{
    public class ParcelService : IParcelService
    {
        private readonly IParcelManager _parcelManager;
        private readonly IEmployeeManager _employeeManager;

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


        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace)
        {
            Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(storePlace);
            if(parcels.Length == 0)
            {
                throw new ParcelNotFoundInDatabaseException(storePlace);
            }


            return parcels;
        }

        public Parcel[] GetParcelsFromStorePlaceByStatus(StorePlace storePlace, ParcelStatus status)
        {
            Parcel[] parcels = _parcelManager.GetParcelsFromStorePlaceByStatus(storePlace, status);
            if (parcels.Length == 0)
            {
                throw new ParcelNotFoundInDatabaseException(storePlace);
            }

            return parcels;
        }

        public void PostParcel(Parcel newParcel)
        {
            if (_parcelManager.PostParcel(newParcel) == 0)
            {
                throw new NothingAddedToDatabaseException(newParcel);
            }
        }
        public void ChangeParcelPriority(Parcel parcelToChange, int priority)
        {
            if (_parcelManager.ChangeParcelPriority(parcelToChange, priority) == 0)
            {
                throw new NothingAddedToDatabaseException(parcelToChange);
            }
        }

        public void ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status)
        {
            if (_parcelManager.ChangeParcelStatus(parcelToChange, status) == 0)
            {
                throw new NothingAddedToDatabaseException(parcelToChange);
            }
        }

        public void ReturnParcel(Parcel oldParcel)
        {
            if (_parcelManager.ReturnParcel(oldParcel) == 0)
            {
                throw new NothingAddedToDatabaseException(oldParcel);
            }
            
        }

        public void AssignCourier(Parcel parcelToChange, int courierId)
        {
            var emploee = _employeeManager.GetEmployeeById(courierId);

            if ( emploee == null )
            {
                throw new Exception("Emploee of id " + courierId + " not found in database.");
            }

            bool isCourier = false;
            foreach ( var employment in emploee.ActiveEmployments )
            {
                if( employment.IsActive && employment.Position.Name.ToLower() == "courier" )
                {
                    isCourier = true;
                    break;
                }
            }

            if (!isCourier)
            {
                throw new Exception("Emploee of id " + courierId + " is not a courier.");
            }

            if (_parcelManager.SetCourierId(parcelToChange, courierId) == 0)
            {
                throw new NothingAddedToDatabaseException(parcelToChange);
            }
        }

        public void UnassignCourier(Parcel parcelToChange)
        {
            if (_parcelManager.SetCourierId(parcelToChange, null) == 0)
            {
                throw new NothingAddedToDatabaseException(parcelToChange);
            }
        }

        public decimal CalculateParcelCost(Parcel parcel)
        {
            decimal cost = _parcelManager.CalculateParcelCost(parcel);
            if (cost <= 0.0M)
            {
                throw new InvalidParcelDimensionsOrWeight(parcel);
            }
            return cost;
        }
    }
}
