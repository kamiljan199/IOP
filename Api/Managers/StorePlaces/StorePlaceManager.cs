using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Data.Context;
using System.Linq;

namespace Api.Managers
{
    public class StorePlaceManager : IStorePlaceManager
    {
        private readonly AppDbContext _context;

        public StorePlaceManager(AppDbContext context)
        {
            _context = context;
        }

        public int AddStoreplace(StorePlace storeplace)
        {
            _context.StorePlaces.Add(storeplace);
            return _context.SaveChanges();
        }

        public int UpdateStoreplace(StorePlace storeplace)
        {
            _context.StorePlaces.Update(storeplace);
            return _context.SaveChanges();
        }

        public int RemoveStoreplace(int id)
        {
            _context.StorePlaces.Remove(GetById(id));
            return _context.SaveChanges();
        }

        public StorePlace GetById(int id)
        {
            return _context.StorePlaces.FirstOrDefault(e => e.Id.Equals(id));
        }
        public List<StorePlace> GetAll()
        {
            return _context.StorePlaces.ToList();
        }
    }
}
