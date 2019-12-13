using Model.Models;
using System;

namespace Api.Services
{
    public interface IStorePlaceService
    {
        public StorePlace GetById(int id);
        public Type GetTypeById(int id);
    }
}
