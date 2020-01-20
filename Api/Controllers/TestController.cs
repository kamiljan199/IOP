using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.Enums;
using Api.DTOs;
using Model.ViewModels;

namespace Api.Controllers
{
    public class TestController
    {
        private readonly IParcelService _parcelService;

        public TestController(IParcelService parcelService)
        {
            _parcelService = parcelService;
        }

        public TestDTO GetAndWriteParcelDetailsById(TestViewModel testViewModel)
        {
            // this is where ViewModel validation is being arranged normally

            try
            {
                var parcel = _parcelService.GetById(testViewModel.ParcelId);

                var result = new TestDTO
                {
                    Status = TestStatus.Success,
                    SenderName = parcel.SenderData.FirstName,
                    ReceiverName = parcel.ReceiverData.FirstName,
                    StoragePointId = (int)parcel.StorePlaceId
                };

                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                var result = new TestDTO
                {
                    Status = TestStatus.Failure
                };

                return result;
            }
        }
    }
}
