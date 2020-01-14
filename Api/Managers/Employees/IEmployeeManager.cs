using System;
using System.Collections.Generic;
using Model.Models;

namespace Api.Managers
{
    public interface IEmployeeManager
    {
        public Employee GetEmployeeById(int employeeId);
        public Employee GetEmployeeByLogin(string login);
        public Employee GetEmployeeByPESEL(int employeePESEL);
        public ICollection<Employee> GetAllEmployees();
        public int SaveChanges();
        public void RemoveEmployee(Employee employee);
        public void AddEmployee(Employee employee, bool detach = false);
        public void UpdateEmployee(Employee employee);
    }
}
