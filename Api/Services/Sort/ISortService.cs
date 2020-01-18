using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Services
{
    public interface ISortService
    {
        void GetParcelsInMagazine();
        void Sort(StorePlace _storePlace);
        void PrintGuidelines();
    }
}