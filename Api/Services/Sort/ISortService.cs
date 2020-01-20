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
        void PrintGuidelines(string filePath);
        public void SendParcelsToWarehouses();
        public void GetParcelsFromPoints();
        public void setStorePlace(int place);
    }
}