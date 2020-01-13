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
