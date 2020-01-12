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
        private readonly IParcelManager _parcelManager;
        private readonly ParcelController _parcelController;

        public SortService(IParcelManager parcelManager, ParcelController parcelController)
        {
            _parcelManager = parcelManager;
            _parcels = new List<Parcel>();
            _parcelController = parcelController;
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
            SortParcelsByStatus();
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

        public void SortParcelsByStatus()
        {
            List<Parcel> sortedParcels = new List<Parcel>();

            sortedParcels = _parcels
                .OrderBy(e => _parcelController.GetParcelStatusById(e.Id))
                .ToList();
        }
    }
}
