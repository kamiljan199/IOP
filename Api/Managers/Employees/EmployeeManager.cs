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
        public Employee GetEmployeeByID(int employeeID)
        {
            return _context.Employees.FirstOrDefault(e => e.Id.Equals(employeeID));
        }
        //Zwraca pracownika o żądanym PESELu
        public Employee GetEmployeeByPESEL(int employeePESEL)
        {
            return _context.Employees.FirstOrDefault(e => e.Pesel.Equals(employeePESEL));
        }
        //Generuje hasło dla pracownika (TODO)
        public string GeneratePasswordForEmployee(int employeeID)
        {
            throw new NotImplementedException();
        }
        //Dodaje pracownika
        public void AddEmployee(string name, string surname, int PESEL, DateTime birthday)
        {
            throw new NotImplementedException();
        }
        //Zwalnia pracownika o podanym numerze ID
        public void FireEmployee(int employeeID)
        {
            _context.Employees.Remove(GetEmployeeByID(employeeID));
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
