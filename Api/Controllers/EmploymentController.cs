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

        public EmploymentsDTO GetAllEmploymentsByEmployeeId(int id)
        {
            try
            {
                var employmentsList = _employmentService.GetAllEmploymentsByEmployeeId(id);

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

        public void CreateEmployment(Employment employment, bool detach = false)
        {
            _employmentService.CreateEmployement(employment, detach);
        }

        public void DeactivateEmployment(Employment employment)
        {
            _employmentService.GetAllEmploymentsByEmployeeId(employment.EmployeeId).ForEach(e =>
            {
                if (e.Id.Equals(employment.Id))
                {
                    e.IsActive = false;
                    _employmentService.UpdateEmployment(e);
                }
            });
        }

        public void UpdateEmployment(Employment employment)
        {
            _employmentService.UpdateEmployment(employment);
        }

        public Employment GetEmploymentById(int id)
        {
            return _employmentService.GetEmploymentById(id);
        }
    }
}
