using Api.Managers;
using Model.Enums;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Services
{
    public interface IParcelService
    {
        public Parcel GetById(int id);
        public Parcel GetByReferenceId(int id);
        public void PostParcel(Parcel newParcel);
        public void ChangeParcelPriority(Parcel parcelToChange, int priority);
        public void ChangeParcelStatus(Parcel parcelToChange, ParcelStatus status);
        public void ReturnParcel(Parcel oldParcel);
    }
}
