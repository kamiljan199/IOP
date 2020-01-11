using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IParcelManager
    {
        public Parcel GetById(int id);
        public Parcel GetByReferenceId(int id);
        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace);
        public int PostParcel(Parcel newParcel);
        public int DeliverParcel(Parcel oldParcel);
        public int ReturnParcel(Parcel oldParcel);
    }
}
