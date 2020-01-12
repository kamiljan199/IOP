using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public interface IEmploymentService
    {
        public List<Employment> GetAllEmploymentsByEmployee(Employee employee);
        public void CreateEmployement(Employment employment);
        public void ChangePosition(int employmentID, Position position);
    }
}
