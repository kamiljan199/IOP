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

            var rowsChange = _employmentManager.SaveChanges();
            if (rowsChange != 1)
            {
                throw new Exception();
            }
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
