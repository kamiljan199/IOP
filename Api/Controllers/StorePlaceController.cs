using System;
using System.Collections.Generic;
using System.Text;
using Api.DTOs;
using Api.Services;
using Api.Enums;
using Model.Models;
using System.Linq;

namespace Api.Controllers
{
    public class StorePlaceController
    {
        private IStorePlaceService _storePlaceService;

        public StorePlaceController(IStorePlaceService storePlaceService)
        {
            _storePlaceService = storePlaceService;
        }

        public StorePlacesDTO GetAllStorePlaces()
        {
            StorePlacesDTO result;
            try
            {
                var collection = _storePlaceService.GetAll();

                result = new StorePlacesDTO
                {
                    StorePlaces = collection,
                    Status = collection.Count > 0 ? CollectionGetStatus.Success : CollectionGetStatus.Empty
                };
            }
            catch
            {
                result = new StorePlacesDTO
                {
                    StorePlaces = null,
                    Status = CollectionGetStatus.Failure
                };
            }

            return result;
        }
        public StorePlacesDTO GetAllWarehouses()
        {
            StorePlacesDTO result;
            try
            {
                var collection = _storePlaceService.GetAll().Where(sp => sp.GetType() == typeof(Warehouse)).ToList();

                result = new StorePlacesDTO
                {
                    StorePlaces = collection,
                    Status = collection.Count > 0 ? CollectionGetStatus.Success : CollectionGetStatus.Empty
                };
            }
            catch
            {
                result = new StorePlacesDTO
                {
                    StorePlaces = null,
                    Status = CollectionGetStatus.Failure
                };
            }

            return result;
        }
        public StorePlacesDTO GetAllSendingPoints()
        {
            StorePlacesDTO result;
            try
            {
                var collection = _storePlaceService.GetAll().Where(sp => sp.GetType() == typeof(SendingPoint)).ToList();

                result = new StorePlacesDTO
                {
                    StorePlaces = collection,
                    Status = collection.Count > 0 ? CollectionGetStatus.Success : CollectionGetStatus.Empty
                };
            }
            catch
            {
                result = new StorePlacesDTO
                {
                    StorePlaces = null,
                    Status = CollectionGetStatus.Failure
                };
            }

            return result;
        }
    }
}
