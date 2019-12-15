using System;
using System.Collections.Generic;
using Model.Models;

namespace Api.Managers
{
    public interface IEmployeeManager
    {
        public Employee GetEmployeeByID(int employeeID);
        public Employee GetEmployeeByPESEL(int employeePESEL);
        public string GeneratePasswordForEmployee(int employeeID);
        public void AddEmployee(string name, string surname, int PESEL, DateTime birthday);
        public void FireEmployee(int employeeID);
        public List<Employee> GetAllEmployees();
    }
}
