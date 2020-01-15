using Api.Managers;
using Model.Enums;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Services
{
    public interface IParcelService
    {
        public Parcel GetById(int id);
        public Parcel GetByReferenceId(int id);
        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace);
        public Parcel[] GetParcelsFromStorePlaceByStatus(StorePlace storePlace, ParcelStatus status);
        public void PostParcel(Parcel newParcel);
        public void ChangeParcelPriority(Parcel parcelToChange, int priority);
        public void ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status);
        public void ReturnParcel(Parcel oldParcel);
        public void AssignCourier(Parcel parcelToChange, int courierId);
        public void UnassignCourier(Parcel parcelToChange);
    }
}
