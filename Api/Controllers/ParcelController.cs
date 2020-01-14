using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Model.Enums;
using Model.Models;
using Model.Models.Exceptions;

namespace Api.Controllers
{
    public class ParcelController
    {
        private readonly IParcelService _parcelService;

        public ParcelController(IParcelService parcelService)
        {
            _parcelService = parcelService;
        }

        public ParcelStatus GetParcelStatusById(int id)
        {
            ParcelStatus status = ParcelStatus.Unknown;
            try
            {
                Parcel postedParcel = _parcelService.GetById(id);
                status = postedParcel.ParcelStatus;
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.Message);
            }

            return status;
        }

        public Parcel[] GetParcelsByStorePlace(StorePlace storePlace)
        {
            Parcel[] parcels = { };
            try
            {
                parcels = _parcelService.GetByStorePlace(storePlace);
            }
            catch(ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.Message);
            }

            return parcels;
        }

        public Parcel[] GetParcelsFromStorePlaceByStatus(StorePlace storePlace, ParcelStatus status)
        {
            Parcel[] parcels = { };
            try
            {
                parcels = _parcelService.GetFromStorePlaceByStatus(storePlace, status);
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.Message);
            }

            return parcels;
        }

        public bool PostParcel(StorePlace storePlace, PersonalData senderData, PersonalData receiverData, float height, float length, float width, int priority, string type)
        {
            var parcel = new Parcel
            {
                StorePlaceId = storePlace.Id,
                SenderData = senderData,
                ReceiverData = receiverData,
                ParcelHeight = height,
                ParcelWidth = width,
                ParcelLength = length,
                Priority = priority,
                ReferenceId = 0,
                ParcelStatus = ParcelStatus.AtPostingPoint
            };
            try
            {
                _parcelService.PostParcel(parcel);
            }
            catch(NothingAddedToDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public bool ChangeParcelPriority(int id, int priority)
        {
            try
            {
                _parcelService.ChangeParcelPriority(_parcelService.GetById(id), priority);
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (NothingAddedToDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public bool ChangeParcelStatus(int id, ParcelStatus status)
        {
            try
            {
                _parcelService.ChangeParcelStatus(_parcelService.GetById(id), status);
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (NothingAddedToDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public bool ReturnParcel(int id)
        {
            try
            {
                _parcelService.ReturnParcel(_parcelService.GetById(id));
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (NothingAddedToDatabaseException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }
    }
}
