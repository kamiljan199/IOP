﻿using System;
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

        public SortService(IParcelManager parcelManager)
        {
            _parcelManager = parcelManager;
            _parcels = new List<Parcel>();
            _parcelsToClients = new List<Parcel>();
            _parcelsToOtherStorePlace = new List<Parcel>();
        }

        public void GetParcelsInMagazine()
        {
            Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(storePlace);
            for(int  i = 0; i < parcels.Length; i++)
            {
                _parcels.Add(parcels[i]);
            }
        }

        public void PrintGuidelines()
        {
            String street;
            String city;
            bool firstTime = true;
            int storePlaceID;
            List<String> instructions = new List<string>();
            instructions.Add("==================\nParcels to send to Clients\n==================");

            street = _parcels[0].ReceiverData.PersonalAddress.Street;
            storePlaceID = _parcels[0].StorePlaceId;
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

                    storePlaceID = p.StorePlaceId;
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

            System.IO.File.WriteAllLines(@"..\..\..\Instructions.txt", instructions);
        }

        public void Sort(List<Parcel> parcels)
        {

            _parcels = _parcels
                .OrderBy(e => e.StorePlaceId)
                .ThenBy(e => e.ReceiverData.PersonalAddress.City)
                .ThenBy(e => e.ReceiverData.PersonalAddress.Street)
                .ThenBy(e => e.ReceiverData.PersonalAddress.HomeNumber)
                .ToList();

            int index = 0;

            //for (int i = 0; i < _parcels.Count; i++)
            //{
            //    if (_parcels[i].StorePlaceId == _storePlace.Id)
            //    {
            //        _parcels.Insert(index++, _parcels[i]);
            //        _parcels.RemoveAt(i + 1);
            //    }
            //}

            //List<Parcel> sortedParcels;
            //SortParcelsByStorePlace();
            //sortedParcels = SortParcelsByAddress(parcelsToSort);
            //SortParcelsByAddress(_parcelsToOtherStorePlace);

            //return sortedParcels;
        }

        public List<Parcel> SortParcelsByAddress(List<Parcel> sortedParcels)
        {
            sortedParcels = sortedParcels
                .OrderBy(e => e.ReceiverData.PersonalAddress.City)
                .ThenBy(e => e.ReceiverData.PersonalAddress.Street)
                .ThenBy(e => e.ReceiverData.PersonalAddress.HomeNumber)
                .ThenBy(e => e.StorePlaceId)
                .ToList();

            return sortedParcels;

            //if (sortedParcels[0].StorePlaceId == _storePlace.Id)
            //{
            //    _parcelsToClients = sortedParcels;
            //}
            //else
            //{
            //    _parcelsToOtherStorePlace = sortedParcels;
            //}
        }

        public void SortParcelsByStorePlace()
        {
            //foreach(var parcel in _parcels)
            //{
            //    if (parcel.StorePlaceId == _storePlace.Id)
            //    {
            //        _parcelsToClients.Add(parcel);
            //    }
            //    else
            //    {
            //        _parcelsToOtherStorePlace.Add(parcel);
            //    }
            //}
        }

        public void SortParcelsByPrivilage()
        {

        }
    }
}
