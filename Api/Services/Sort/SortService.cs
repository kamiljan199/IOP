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

        public void GetParcelsInMagazine()
        {
            //Parcel[] parcels = _parcelManager.GetParcelsByStorePlace(_storePlace);
            //for(int  i = 0; i < parcels.Length; i++)
            //{
            //    _parcels.Add(parcels[i]);
            //}
        }

        public void PrintGuidelines()
        {
            List<String> instructions = new List<string>();
            instructions.Add("\nParcels to send to Clients\n");
            foreach (var p in _parcelsToClients)
            {
                instructions.Add(p.ReceiverData.PersonalAddress.City + " " + p.ReceiverData.PersonalAddress.Street +
                                 " " + p.ReceiverData.PersonalAddress.HomeNumber +
                                 " " + p.StorePlaceId);
                //                Console.WriteLine();
            }
            instructions.Add("\nParcels to send to different Warehouse\n");
            //            Console.WriteLine("\n");
            foreach (var p in _parcelsToOtherStorePlace)
            {
                instructions.Add(p.ReceiverData.PersonalAddress.City + " " + p.ReceiverData.PersonalAddress.Street +
                                 " " + p.ReceiverData.PersonalAddress.HomeNumber +
                                 " " + p.StorePlaceId);
            }
            //Path yet to decide
            //System.IO.File.WriteAllLines(@"..\..\..\Data\Instructions.txt", instructions);
        }

        public List<Parcel> Sort(List<Parcel> parcelsToSort)
        {
            List<Parcel> sortedParcels;
            //SortParcelsByStorePlace();
            sortedParcels = SortParcelsByAddress(parcelsToSort);
            //SortParcelsByAddress(_parcelsToOtherStorePlace);

            return sortedParcels;
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
