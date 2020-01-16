using System;
using System.Collections.Generic;
using Model.Models;
using System.Linq;
using Data.Context;
using Microsoft.EntityFrameworkCore;

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
            var e = _context.Employees.FirstOrDefault(e => e.Id.Equals(employeeId));
            e.ActiveEmployments = _context.Employments.Where(em => em.EmployeeId.Equals(e.Id) && em.IsActive.Equals(true)).ToList();
            return e;
        }

        public Employee GetEmployeeByLogin(string login)
        {
            return _context.Employees.FirstOrDefault(e => e.Login.Equals(login));
        }

        //Zwraca pracownika o żądanym PESELu
        public Employee GetEmployeeByPESEL(int employeePESEL)
        {
            return _context.Employees.FirstOrDefault(e => e.Pesel.Equals(employeePESEL));
        }

        public void AddEmployee(Employee employee, bool detach = false)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            if (detach)
            {
                _context.Entry(employee).State = EntityState.Detached;
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        ICollection<Employee> IEmployeeManager.GetAllEmployees()
        {
            var list = _context.Employees.AsNoTracking().ToList();
            list.ForEach(e => e.ActiveEmployments = _context.Employments.Where(em => em.EmployeeId.Equals(e.Id) && em.IsActive.Equals(true)).ToList());
            return list;

        }

        public List<Employee> GetEmployeesByPositionId(int positionId)
        {
            var list = _context.Employees.ToList();
            list.ForEach(e => e.ActiveEmployments = _context.Employments.Where(em => em.EmployeeId.Equals(e.Id) && em.IsActive.Equals(true)).ToList());
            return list.FindAll(e => e.ActiveEmployments.Count > 0 && e.ActiveEmployments[0].PositionId == positionId);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
