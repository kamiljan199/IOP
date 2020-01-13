using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Data.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Managers
{
    public class EmploymentManager : IEmploymentManager
    {
        private readonly AppDbContext _context;
        
        public EmploymentManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployment(Employment employment, bool detach = false)
        {
            _context.Employments.Add(employment);
            _context.SaveChanges();
            if (detach)
            {
                _context.Entry(employment).State = EntityState.Detached;
            }
        }

        public void ChangePosition(int employmentID, Position position)
        {
            GetEmploymentByID(employmentID).Position = position;
        }

        public List<Employment> GetAllEmploymentsByEmployeeId(int id)
        {
            return _context.Employments.Where(e => e.EmployeeId == id).AsNoTracking().ToList();
        }

        public Employment GetEmploymentByID(int employmentID)
        {
            return _context.Employments.FirstOrDefault(e => e.Id.Equals(employmentID));
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateEmployment(Employment employment)
        {
            _context.Entry(employment).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
