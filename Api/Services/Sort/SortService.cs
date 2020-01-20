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
        private StorePlace storePlace;
        private readonly IParcelManager _parcelManager;
        private readonly IRouteManager _routeManager;
        private readonly IStorePlaceManager _storePlaceManager;

        public SortService(IParcelManager parcelManager, IRouteManager routeManager, IStorePlaceManager storePlaceManager)
        {
            _parcelManager = parcelManager;
            _routeManager = routeManager;
            _storePlaceManager = storePlaceManager;
            _parcels = new List<Parcel>();
            _parcelsToClients = new List<Parcel>();
            _parcelsToOtherStorePlace = new List<Parcel>();
        }


        public void setStorePlace(int place)
        {
            storePlace = _storePlaceManager.GetById(place);
        }

        public void GetParcelsInMagazine()
        {
            _parcels.Clear();

            Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(storePlace);
            for(int  i = 0; i < parcels.Length; i++)
            {
                _parcels.Add(parcels[i]);
            }
        }

        public void PrintGuidelines(string filePath)
        {
            
            String street;
            String city;
            bool firstTime = true;
            int? storePlaceID;
            List<String> instructions = new List<string>();
            instructions.Add("==================\nParcels to send to Clients\n==================");

            street = _parcels[0].ReceiverData.PersonalAddress.Street;
            storePlaceID = (int)_parcels[0].StorePlaceId;
            city = _parcels[0].ReceiverData.PersonalAddress.City;

            instructions.Add("STORE PLACE: " + storePlaceID);
            instructions.Add("CITY: " + city);
            instructions.Add("STREET: " + street);

            foreach (var p in _parcels)
            {
                if (storePlaceID != p.StorePlaceId ||
                    city != p.ReceiverData.PersonalAddress.City ||
                    street != p.ReceiverData.PersonalAddress.Street)
                {
                    instructions.Add("===================================");
                }
                if (storePlaceID != p.StorePlaceId)
                {
                    if (firstTime)
                    {
                        firstTime = false;
                        instructions.Add("==================\nParcels to send to different Warehouse\n==================");
                    }

                    storePlaceID = (int)p.StorePlaceId;
                    instructions.Add("STORE PLACE: " + storePlaceID);
                }
                if (city != p.ReceiverData.PersonalAddress.City)
                {
                    city = p.ReceiverData.PersonalAddress.City;
                    instructions.Add("CITY: " + city);

                }
                if (street != p.ReceiverData.PersonalAddress.Street)
                {
                    street = p.ReceiverData.PersonalAddress.Street;
                    instructions.Add("STREET: " + street);
                }
                instructions.Add("________________________\n" +
                                 p.ReceiverData.PersonalAddress.City + " " +
                                 p.ReceiverData.PersonalAddress.Street +
                                 " " + p.ReceiverData.PersonalAddress.HomeNumber +
                                 " " + p.StorePlaceId);
            }

            System.IO.File.WriteAllLines(filePath, instructions);
        }

        public List<Parcel> Sort(List<Parcel> parcels)
        {

            _parcels = parcels
                .OrderBy(e => e.StorePlaceId)
                .ThenBy(e => e.ReceiverData.PersonalAddress.City)
                .ThenBy(e => e.ReceiverData.PersonalAddress.Street)
                .ThenBy(e => e.ReceiverData.PersonalAddress.HomeNumber)
                .ToList();

            int index = 0;

            for (int i = 0; i < _parcels.Count; i++)
            {
                if (_parcels[i].StorePlaceId == storePlace.Id)
                {
                    _parcels.Insert(index++, _parcels[i]);
                    _parcels.RemoveAt(i + 1);
                }
            }

            return _parcels;
        }

        public void GetParcelsFromPoints()
        {
            List<StorePlace> storePlaces;
            Parcel[] parcels;
            List<Parcel> allParcels = new List<Parcel>();
            storePlaces = _storePlaceManager.GetAll();
            foreach (var point in storePlaces)
            {
                if (point.Type == 1)
                {
                    parcels = _parcelManager.GetParcelsByStorePlace(point);
                    foreach (var parcel in parcels)
                    {
                        _parcelManager.ChangeParcelStorePlace(parcel, storePlace.Id);
                        _parcelManager.ChangeParcelStatus(parcel, Model.Enums.ParcelStatus.InWarehouse);
                        //allParcels.Add(parcel);
                    }
                }

            }
            /*foreach (var par in allParcels)
            {
                _parcelManager.ChangeParcelStorePlace(par, storePlace.Id);
            }*/
        }

        public void SendParcelsToWarehouses()
        {
            GetParcelsInMagazine();

            int? spID = storePlace.Id;

            foreach (var parcel in _parcels)
            {
                spID = parcel.StorePlaceId;
                _parcelManager.ChangeParcelStorePlace(parcel, spID.Value);
            }
            
        }

        private bool isAnymoreToSend()
        {
            foreach (var parcel in _parcels)
            {
                if(parcel.StorePlaceId != storePlace.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
