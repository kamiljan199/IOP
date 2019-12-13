using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IParcelManager
    {
        public Parcel GetById(int id);
    }
}
