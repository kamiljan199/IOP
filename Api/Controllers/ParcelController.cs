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
                parcels = _parcelService.GetParcelsByStorePlace(storePlace);
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
                parcels = _parcelService.GetParcelsFromStorePlaceByStatus(storePlace, status);
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.Message);
            }

            return parcels;
        }

        public bool PostParcel(StorePlace storePlace, PersonalData senderData, PersonalData receiverData, float height, float length, float width, float weight, int priority, string type)
        {
            var parcel = new Parcel
            {
                StorePlaceId = storePlace.Id,
                SenderData = senderData,
                ReceiverData = receiverData,
                ParcelHeight = height,
                ParcelWidth = width,
                ParcelLength = length,
                ParcelWeight = weight,
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

        public bool PostParcel(Parcel parcel)
        {
            parcel.ParcelStatus = ParcelStatus.AtPostingPoint;
            parcel.ReferenceId = 0;
            try
            {
                _parcelService.PostParcel(parcel);
            }
            catch (NothingAddedToDatabaseException e)
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

        public decimal GetParcelCost(Parcel parcel)
        {
            decimal cost;
            try
            {
                cost = _parcelService.CalculateParcelCost(parcel);
            }
            catch (InvalidParcelDimensionsOrWeight e)
            {
                Console.WriteLine(e);
                return 0;
            }
            return cost;
        }

        public string GetParcelType(double weight, float x, float y, float z)
        {
            string type = "None";
            float edgeSum = Math.Min(x, Math.Min(y, z)) +
                            Math.Max(x, Math.Max(y, z));
            if (edgeSum < 35.0 && weight < 1.0)
            {
                type = "A";
            }
            else if (edgeSum < 75.0 && weight < 10.0)
            {
                type = "B";
            }
            else if (edgeSum < 180.0 && weight < 31.5)
            {
                type = "C";
            }

            return type;
        }
    }
}
