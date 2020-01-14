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
        public int PostParcel(Parcel newParcel);
        public int ChangeParcelPriority(Parcel parcelToChange, int priority);
        public int ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status);
        public int ReturnParcel(Parcel oldParcel);
        public int SetCourierId(Parcel parcelToChange, int? courierId);
    }
}
