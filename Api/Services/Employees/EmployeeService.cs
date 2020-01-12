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

        public ICollection<Employee> GetAllEmployees()
        {
            var employeeList = _employeeManager.GetAllEmployees();
            if (employeeList.Count.Equals(0))
            {
                throw new Exception($"No employee has been found");
            }

            return employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _employeeManager.GetEmployeeById(id);
            if(employee == default(Employee))
            {
                throw new Exception();
            }

            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeManager.AddEmployee(employee);

            var rowsChange = _employeeManager.SaveChanges();
            if(rowsChange != 1)
            {
                throw new Exception();
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            _employeeManager.RemoveEmployee(employee);

            var rowsChange = _employeeManager.SaveChanges();
            if (rowsChange != 1)
            {
                throw new Exception();
            }
        }

        public void RemoveEmployeeById(int id)
        {
            var employee = GetEmployeeById(id);
            RemoveEmployee(employee);
        }

        public void HireEmployee(Employee employee, Employment employment)
        {
            _employeeManager.HireEmployee(employee, employment);
        }
    }
}
