using Api.Managers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Services
{
    public class StorePlaceService : IStorePlaceService
    {
        private readonly IStorePlaceManager _storePlaceManager;

        public StorePlaceService(IStorePlaceManager storePlaceManager)
        {
            _storePlaceManager = storePlaceManager;
        }

        public StorePlace GetById(int id)
        {
            var storePlace = _storePlaceManager.GetById(id);
            if(storePlace == default(StorePlace))
            {
                throw new Exception($"Store place identified as ${ id } not found.");
            }

            return storePlace;
        }

        public Type GetTypeById(int id)
        {
            var storePlace = GetById(id);

            return storePlace.GetType();
        }

        public List<StorePlace> GetAll() => _storePlaceManager.GetAll();
    }
}
