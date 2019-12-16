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

        public void GetParcelsInMagazine(int id)
        {
            _parcels = _parcelManager.GetAllParcelsFromWarehouse(id);
        }

        public void Sort()
        {
            List<Parcel> sortedParcels = new List<Parcel>();
            List<Parcel> sortedByCity = new List<Parcel>();
            List<Parcel> sortedByStreet = new List<Parcel>();
            List<Parcel> sortedByNumber = new List<Parcel>();
            sortedParcels.Clear();
            Parcel nextParcel = _parcels[0];
            int numberOfParcelsInMagazine = _parcels.Count;
            while (sortedByCity.Count < numberOfParcelsInMagazine)
            {
                for (int i = 0; i < _parcels.Count; i++)
                {
                    if (_parcels[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = _parcels[i];
                    }
                }
                sortedByCity.Add(nextParcel);
                _parcels.Remove(nextParcel);
            }
            nextParcel = sortedByCity[0];
            while (sortedByStreet.Count < numberOfParcelsInMagazine)
            {
                for (int i = 0; i < sortedByCity.Count; i++)
                {
                    if (sortedByCity[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = sortedByCity[i];
                    }
                }
                sortedByStreet.Add(nextParcel);
                sortedByCity.Remove(nextParcel);
            }
            nextParcel = sortedByStreet[0];
            while (sortedByNumber.Count < numberOfParcelsInMagazine)
            {
                for (int i = 0; i < sortedByStreet.Count; i++)
                {
                    if (sortedByStreet[i].ReceiverData.PersonalAddress.City.CompareTo(nextParcel.ReceiverData.PersonalAddress.City) < 0)
                    {
                        nextParcel = sortedByStreet[i];
                    }
                }
                sortedByNumber.Add(nextParcel);
                sortedByStreet.Remove(nextParcel);
            }
        }
    }
}
