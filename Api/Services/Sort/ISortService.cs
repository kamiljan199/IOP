using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Services
{
    public interface ISortService
    {
        void GetParcelsInMagazine(StorePlace store);
        void Sort(int storePlaceId);
        void SortParcelsByAddress();
        void SortParcelsByStorePlace(int storePlaceId);
    }
}