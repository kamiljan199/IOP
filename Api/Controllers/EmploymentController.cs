using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.DTOs;
using Api.Enums;

namespace Api.Controllers
{
    public class EmploymentController
    {
        private readonly IEmploymentService _employmentService;
        public EmploymentController(IEmploymentService employmentService)
        {
            _employmentService = employmentService;
        }

        public EmploymentsDTO GetAllEmployments()
        {
            try
            {
                var employmentsList = _employmentService.GetAllEmployments();

                var result = new EmploymentsDTO
                {
                    Employments = employmentsList,
                    Status = CollectionGetStatus.Success
                };

                return result;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);

                var result = new EmploymentsDTO
                {
                    Status = CollectionGetStatus.Failure
                };

                return result;
            }
        }
    }
}
