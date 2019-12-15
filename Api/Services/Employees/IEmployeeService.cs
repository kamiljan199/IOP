using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public interface IEmployeeService
    {
        public string GeneratePasswordForEmployee(int employeeID);
        public void CreateEmployee(string name, string surname, int PESEL, DateTime birthday);
        public void FireEmployee(int employeeID);
        public List<Employee> GetAllEmployees();
    }
}
