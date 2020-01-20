using System;
using System.Collections.Generic;
using System.Text;
using Model.Enums;
using Model.Models;

namespace Api.Managers
{
    public interface IParcelManager
    {
        public Parcel GetById(int id);
        public Parcel GetByReferenceId(int id);
        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace);
        public Parcel[] GetParcelsByStorePlaceWithAddress(StorePlace storePlace);
        public Parcel[] GetParcelsFromStorePlaceByStatus(StorePlace storePlace, ParcelStatus status);
        public Parcel[] GetAllParcels();
        public int PostParcel(Parcel newParcel);
        public int ChangeParcelPriority(Parcel parcelToChange, int priority);
        public int ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status);
        public int ChangeParcelStorePlace(Parcel parcelToChange, int storePlaceID);
        public int ReturnParcel(Parcel oldParcel);
        public int SetCourierId(Parcel parcelToChange, int? courierId);
        public decimal CalculateParcelCost(Parcel parcel);
    }
}
