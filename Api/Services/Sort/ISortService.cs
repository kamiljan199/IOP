using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Services
{
    public interface ISortService
    {
        void GetParcelsInMagazine();
        List<Parcel> Sort(List<Parcel> parcels);
        void PrintGuidelines();
        public void SendParcelsToWarehouses();
    }
}