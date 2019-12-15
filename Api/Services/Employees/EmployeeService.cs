using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeeService(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        public void CreateEmployee(string name, string surname, int PESEL, DateTime birthday)
        {
            _employeeManager.AddEmployee(name, surname, PESEL, birthday);
        }

        public void FireEmployee(int employeeID)
        {
            _employeeManager.FireEmployee(employeeID);
        }

        public string GeneratePasswordForEmployee(int employeeID)
        {
            return _employeeManager.GeneratePasswordForEmployee(employeeID);
        }

        public List<Employee> GetAllEmployees()
        {
            var employeeList = _employeeManager.GetAllEmployees();
            if (employeeList.Count.Equals(0))
            {
                throw new Exception($"No employee has been found");
            }
            return employeeList;
        }
    }
}
