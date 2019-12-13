using Api.Controllers;
using System;
using Autofac;
using Model.ViewModels;

namespace Api
{
    class Program
    {
        //Only for API testing purposes
        private static IContainer container;
        
        static void Main(string[] args)
        {
            Startup startup = new Startup();
            container = startup.ConfigureAndBuild();

            using(var scope = container.BeginLifetimeScope())
            {
                var controller = scope.Resolve<TestController>();
                
                var testViewModel = new TestViewModel
                {
                    PackageId = 1
                };

                controller.GetAndWritePackageDetailsById(testViewModel);
            }
        }
    }
}
