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
        private readonly IPackageService _packageService;

        public TestController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        public TestDTO GetAndWritePackageDetailsById(TestViewModel testViewModel)
        {
            // this is where ViewModel validation is being arranged normally

            try
            {
                var package = _packageService.GetById(testViewModel.PackageId);

                var result = new TestDTO
                {
                    Status = TestStatus.Success,
                    SenderName = package.SenderName,
                    ReceiverName = package.ReceiverName,
                    StoragePointId = package.StorePlaceId
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
