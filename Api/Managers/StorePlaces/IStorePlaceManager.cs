using Model.Models;
using System.Collections.Generic;

namespace Api.Managers
{
    public interface IStorePlaceManager
    {
        public StorePlace GetById(int id);
        public List<StorePlace> GetAll();
    }
}
