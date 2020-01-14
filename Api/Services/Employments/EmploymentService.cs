using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;


namespace Api.Services
{
    public class EmploymentService : IEmploymentService
    {
        private readonly IEmploymentManager _employmentManager;
        public EmploymentService(IEmploymentManager employmentManager)
        {
            _employmentManager = employmentManager;
        }
        public void CreateEmployement(Employment employment, bool detach = false)
        {
            _employmentManager.AddEmployment(employment, detach);
        }

        public List<Employment> GetAllEmploymentsByEmployeeId(int id)
        {
            var employmentsList = _employmentManager.GetAllEmploymentsByEmployeeId(id);
            if (employmentsList.Count.Equals(0))
            {
                throw new Exception($"No employment has been found");
            }
            return employmentsList;
        }

        public void UpdateEmployment(Employment employment)
        {
            _employmentManager.UpdateEmployment(employment);
        }

        public Employment GetEmploymentById(int id)
        {
            return _employmentManager.GetEmploymentByID(id);
        }
    }
}
