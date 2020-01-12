using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Api.Controllers;
using Model.Models;
using System.Linq;

namespace Api.Services
{
    class SortService : ISortService
    {
        private List<Parcel> _parcels;
        private List<Parcel> _parcelsToClients;
        private List<Parcel> _parcelsToOtherStorePlace;
        private readonly IParcelManager _parcelManager;

        public SortService(IParcelManager parcelManager)
        {
            _parcelManager = parcelManager;
            _parcels = new List<Parcel>();
            _parcelsToClients = new List<Parcel>();
            _parcelsToOtherStorePlace = new List<Parcel>();
        }

        public void GetParcelsInMagazine(StorePlace store)
        {
            Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(store);
            for(int  i = 0; i < parcels.Length; i++)
            {
                _parcels.Add(parcels[i]);
            }
        }

        public void Sort(int storePlaceId)
        {
            SortParcelsByAddress();
            SortParcelsByStorePlace(storePlaceId);
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

        public void SortParcelsByStorePlace(int storePlaceId)
        {
            List<Parcel> sortedParcels = new List<Parcel>();

            foreach(var parcel in _parcels)
            {
                if (parcel.StorePlaceId == storePlaceId)
                {
                    _parcelsToClients.Add(parcel);
                    _parcels.Remove(parcel);
                }
                else
                {
                    _parcelsToOtherStorePlace.Add(parcel);
                    _parcels.Remove(parcel);
                }
            }
        }
    }
}
