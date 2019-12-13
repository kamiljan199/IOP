using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IPackageManager
    {
        public Package GetById(int id);
        public Package GetByReceiverAddress(Address address);
    }
}
