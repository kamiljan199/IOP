using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

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
            List<Parcel> sortedByCity = new List<Parcel>();
            List<Parcel> sortedByStreet = new List<Parcel>();
            List<Parcel> sortedByNumber = new List<Parcel>();
            sortedParcels.Clear();
            Parcel nextParcel = _parcels[0];
            int index = 0;
            int numberOfParcelsInMagazine = _parcels.Count;
            while (sortedByCity.Count < numberOfParcelsInMagazine)
            {
                nextParcel = _parcels[0];
                for (int i = 0; i < _parcels.Count; i++)
                {
                    if (_parcels[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = _parcels[i];
                        index = i;
                    }
                }
                sortedByCity.Add(nextParcel);
                _parcels.RemoveAt(index);
                index = 0;
            }

            nextParcel = sortedByCity[0];
            while (sortedByStreet.Count < numberOfParcelsInMagazine)
            {
                nextParcel = sortedByCity[0];
                for (int i = 0; i < sortedByCity.Count; i++)
                {
                    if (sortedByCity[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = sortedByCity[i];
                        index = i;
                    }
                }
                sortedByStreet.Add(nextParcel);
                sortedByCity.RemoveAt(index);
                index = 0;
            }

            nextParcel = sortedByStreet[0];
            while (sortedByNumber.Count < numberOfParcelsInMagazine)
            {
                nextParcel = sortedByStreet[0];
                for (int i = 0; i < sortedByStreet.Count; i++)
                {
                    if (sortedByStreet[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = sortedByStreet[i];
                        index = i;
                    }
                }
                sortedByNumber.Add(nextParcel);
                sortedByStreet.RemoveAt(index);
                index = 0;
            }

            foreach (var parcel in sortedByNumber)
            {
                sortedParcels.Add(parcel);
            }
        }
    }
}
