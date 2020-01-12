using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.DTOs;
using Api.Enums;
using Model.Models;

namespace Api.Controllers
{
    public class EmploymentController
    {
        private readonly IEmploymentService _employmentService;
        private readonly IPositionService _positionService;
        public EmploymentController(IEmploymentService employmentService, IPositionService positionService)
        {
            _employmentService = employmentService;
            _positionService = positionService;
        }

        public EmploymentsDTO GetAllEmploymentsByEmployee(Employee employee)
        {
            try
            {
                var employmentsList = _employmentService.GetAllEmploymentsByEmployee(employee);

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

        public void CreateEmployment(int employeeID, DateTime startDate, Position position, float salary, Warehouse warehouse)
        {
            var employment = new Employment
            {
                Id = employeeID,
                StartDate = startDate,
                Position = position,
                Salary = salary,
                Warehouse = warehouse
            };

            //_employmentService.CreateEmployement(employment);
        }

        public void CreateEmployment(Employment employment)
        {
            _employmentService.CreateEmployement(employment);
        }

        public void DeactivateEmployment(Employment employment)
        {
            _employmentService.GetAllEmploymentsByEmployee(employment.Employee).ForEach(e =>
            {
                if (e.Id.Equals(employment.Id))
                {
                    e.IsActive = false;
                    _employmentService.UpdateEmployment(e);
                }
            });
        }

        public void ChangePosition(int employmentID, int positionID)
        {
            _employmentService.ChangePosition(employmentID, _positionService.GetPositionByID(positionID));
        }
    }
}
