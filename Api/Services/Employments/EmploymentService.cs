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
        public void CreateEmployement(int employeeID, DateTime startDate, int position, double salary, int warehouseID)
        {
            _employmentManager.AddEmployment(employeeID, startDate, position, salary, warehouseID);
        }

        public List<Employment> GetAllEmployments()
        {
            var employmentsList = _employmentManager.GetAllEmployments();
            if (employmentsList.Count.Equals(0))
            {
                throw new Exception($"No employment has been found");
            }
            return employmentsList;
        }
    }
}
