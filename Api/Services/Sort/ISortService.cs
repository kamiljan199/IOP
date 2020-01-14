using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Services
{
    public interface ISortService
    {
        void GetParcelsInMagazine();
        List<Parcel> Sort(List<Parcel> parcelsToSort);
        List<Parcel> SortParcelsByAddress(List<Parcel> parcels);
        void SortParcelsByStorePlace();
        void SortParcelsByPrivilage();
        void PrintGuidelines();
    }
}