using System;
using System.Collections.Generic;
using Model.Models;
using System.Linq;
using Data.Context;

namespace Api.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly AppDbContext _context;

        public EmployeeManager(AppDbContext context)
        {
            _context = context;
        }
        //Zwraca pracownika o żądanym numerze ID
        public Employee GetEmployeeById(int employeeId)
        {
            return _context.Employees.FirstOrDefault(e => e.Id.Equals(employeeId));
        }
        //Zwraca pracownika o żądanym PESELu
        public Employee GetEmployeeByPESEL(int employeePESEL)
        {
            return _context.Employees.FirstOrDefault(e => e.Pesel.Equals(employeePESEL));
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        ICollection<Employee> IEmployeeManager.GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void HireEmployee(Employee employee, Employment employment)
        {
            employee.ActiveEmployment = employment;
            _context.SaveChanges();
        }
    }
}
