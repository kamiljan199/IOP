using System;
using System.Collections.Generic;
using Model.Models;

namespace Api.Managers
{
    public interface IEmployeeManager
    {
        public Employee GetEmployeeById(int employeeId);
        public Employee GetEmployeeByPESEL(int employeePESEL);
        public void AddEmployee(Employee employee);
        public void RemoveEmployee(Employee employee);
        public ICollection<Employee> GetAllEmployees();
        public int SaveChanges();
    }
}
