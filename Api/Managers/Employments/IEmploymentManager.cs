using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IEmploymentManager
    {
        public Employment GetEmploymentByID(int employmentID);
        public void AddEmployment(int employeeID, DateTime startTime, int position, double salary, int warehouseID);
        public List<Employment> GetAllEmployments();
    }
}
