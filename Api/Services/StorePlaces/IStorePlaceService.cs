using Model.Models;
using System;
using System.Collections.Generic;

namespace Api.Services
{
    public interface IStorePlaceService
    {
        public StorePlace GetById(int id);
        public Type GetTypeById(int id);
        public List<StorePlace> GetAll();
        public List<Parcel> GetCouriersParcels(StorePlace storePlace, int courierId);
    }
}
