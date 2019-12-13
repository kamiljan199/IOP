using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Data.Context;

namespace Api.Managers
{
    public class ParcelManager : IParcelManager
    {
        private readonly AppDbContext _context;

        public ParcelManager(AppDbContext context)
        {
            _context = context;
        }

        public Parcel GetById(int id)
        {
            return _context.Parcels.FirstOrDefault(e => e.Id.Equals(id));
        }

        public Parcel GetByReceiverAddress(Address address)
        {
            return _context.Parcels.FirstOrDefault(e => e.ReceiverAddress.Id.Equals(address.Id));
        }
    }
}
