using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.Enums;
using Model.Models;
using Model.Models.Exceptions;

namespace Api.Controllers
{
    public class ParcelController
    {
        private readonly IParcelService _parcelService;

        public ParcelController(IParcelService parcelService)
        {
            _parcelService = parcelService;
        }

        public ParcelStatus GetParcelStatusById(int id)
        {
            ParcelStatus status = ParcelStatus.Unknown;
            try
            {
                Parcel postedParcel = _parcelService.GetById(id);
                status = ParcelStatus.Posted;
                try
                {
                    Parcel returnedParcel = _parcelService.GetByReferenceId(id);
                    status = ParcelStatus.Returned;
                }
                catch (ParcelNotFoundInDatabaseException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (ParcelNotFoundInDatabaseException e)
            {
                Console.WriteLine(e.Message);
            }

            return status;
        }

        public void ReturnParcel(int id)
        {
            
        }
    }
}
