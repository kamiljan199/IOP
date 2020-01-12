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
        public void CreateEmployement(Employment employment)
        {
            _employmentManager.AddEmployment(employment);

            /*var rowsChange = _employmentManager.SaveChanges();
            if (rowsChange != 1)
            {
                throw new Exception();
            }*/
        }

        public List<Employment> GetAllEmploymentsByEmployee(Employee employee)
        {
            var employmentsList = _employmentManager.GetAllEmploymentsByEmployee(employee);
            if (employmentsList.Count.Equals(0))
            {
                throw new Exception($"No employment has been found");
            }
            return employmentsList;
        }

        public void ChangePosition(int employmentID, Position position)
        {
            _employmentManager.ChangePosition(employmentID, position);

            var rowsChange = _employmentManager.SaveChanges();
            if (rowsChange != 1)
            {
                throw new Exception();
            }
        }
    }
}
