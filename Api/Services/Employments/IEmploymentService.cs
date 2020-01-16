using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public interface IEmploymentService
    {
        public List<Employment> GetAllEmploymentsByEmployeeId(int id);
        public void CreateEmployement(Employment employment, bool detach = false);
        public void UpdateEmployment(Employment employment);
        public Employment GetEmploymentById(int id);
    }
}
