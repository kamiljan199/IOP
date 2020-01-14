using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IEmploymentManager
    {
        public Employment GetEmploymentByID(int employmentID);
        public void AddEmployment(Employment employment, bool detach = false);
        public List<Employment> GetAllEmploymentsByEmployeeId(int id);
        public int SaveChanges();
        public void UpdateEmployment(Employment employment);
    }
}
