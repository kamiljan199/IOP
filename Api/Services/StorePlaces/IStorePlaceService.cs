using Model.Models;
using System;
using System.Collections.Generic;

namespace Api.Services
{
    public interface IStorePlaceService
    {
        public StorePlace GetById(int id);
        public Type GetTypeById(int id);
        public void AddStoreplace(StorePlace storeplace);
        public void UpdateStoreplace(StorePlace storeplace);
        public void RemoveStoreplace(int id);
        public List<StorePlace> GetAll();
        public List<Parcel> GetCouriersParcels(StorePlace storePlace, int courierId);
    }
}
