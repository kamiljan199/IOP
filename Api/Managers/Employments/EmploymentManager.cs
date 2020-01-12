using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Data.Context;
using System.Linq;

namespace Api.Managers
{
    public class EmploymentManager : IEmploymentManager
    {
        private readonly AppDbContext _context;
        
        public EmploymentManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployment(Employment employment)
        {
            _context.Employments.Add(employment);
            _context.SaveChanges();
        }

        public void ChangePosition(int employmentID, Position position)
        {
            GetEmploymentByID(employmentID).Position = position;
        }

        public List<Employment> GetAllEmploymentsByEmployee(Employee employee)
        {
            var query = from e in _context.Employments
                        where e.Employee.Id == employee.Id
                        select e;
            return query.ToList();
        }

        public Employment GetEmploymentByID(int employmentID)
        {
            return _context.Employments.FirstOrDefault(e => e.Id.Equals(employmentID));
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
