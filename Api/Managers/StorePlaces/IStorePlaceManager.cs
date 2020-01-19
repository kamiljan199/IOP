using Model.Models;
using System.Collections.Generic;

namespace Api.Managers
{
    public interface IStorePlaceManager
    {
        public int AddStoreplace(StorePlace storeplace);
        public int UpdateStoreplace(StorePlace storeplace);
        public int RemoveStoreplace(int id);
        public StorePlace GetById(int id);
        public StorePlace GetByIdWithAddress(int id);
        public List<StorePlace> GetAll();
        public int SaveChanges();
    }
}
