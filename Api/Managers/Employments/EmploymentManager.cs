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
        }

        public List<Employment> GetAllEmployments()
        {
            return _context.Employments.ToList();
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
