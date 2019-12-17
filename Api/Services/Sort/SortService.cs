using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;
using System.Linq;

namespace Api.Services
{
    class SortService : ISortService
    {
        private List<Parcel> _parcels;
        private readonly IParcelManager _parcelManager;

        public SortService(IParcelManager parcelManager)
        {
            _parcelManager = parcelManager;
            _parcels = new List<Parcel>();
        }

        public void GetParcelsInMagazine(StorePlace store)
        {
            Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(store);
            for(int  i = 0; i < parcels.Length; i++)
            {
                _parcels.Add(parcels[i]);
            }
        }

        public void Sort()
        {
            SortParcelsByAddress();
        }

        public void SortParcelsByAddress()
        {
            List<Parcel> sortedParcels = new List<Parcel>();

            sortedParcels = _parcels
                .OrderBy(e => e.ReceiverData.PersonalAddress.City)
                .ThenBy(e => e.ReceiverData.PersonalAddress.Street)
                .ThenBy(e => e.ReceiverData.PersonalAddress.HomeNumber)
                .ToList();
        }
    }
}
