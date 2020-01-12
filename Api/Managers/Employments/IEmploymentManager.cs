using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IEmploymentManager
    {
        public Employment GetEmploymentByID(int employmentID);
        public void AddEmployment(Employment employment);
        public List<Employment> GetAllEmploymentsByEmployee(Employee employee);
        public int SaveChanges();
        public void ChangePosition(int employmentID, Position position);
    }
}
