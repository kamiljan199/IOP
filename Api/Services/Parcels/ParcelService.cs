using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public class ParcelService : IParcelService
    {
        private readonly IParcelManager _packageManager;

        public ParcelService(IParcelManager packageManager)
        {
            _packageManager = packageManager;
        }
        
        public Parcel GetById(int id)
        {
            var package = _packageManager.GetById(id);
            if(package == default(Parcel))
            {
                throw new Exception($"Parcel identified as { id } not found.");
            }

            return package;
        }

        public void PostParcel(Parcel newParcel)
        {
            _packageManager.PostParcel(newParcel);
        }

        public void ReturnParcel(Parcel oldParcel)
        {
            _packageManager.ReturnParcel(oldParcel);
        }
    }
}
