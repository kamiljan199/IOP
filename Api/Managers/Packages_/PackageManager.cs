using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Data.Context;

namespace Api.Managers
{
    public class PackageManager : IPackageManager
    {
        private readonly AppDbContext _context;

        public PackageManager(AppDbContext context)
        {
            _context = context;
        }

        public Package GetById(int id)
        {
            return _context.Packages.FirstOrDefault(e => e.Id.Equals(id));
        }

        public Package GetByReceiverAddress(Address address)
        {
            return _context.Packages.FirstOrDefault(e => e.ReceiverAddress.Id.Equals(address.Id));
        }
    }
}
