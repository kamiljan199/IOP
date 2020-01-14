using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Data.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Managers
{
    public class PositionManager : IPositionManager
    {
        private readonly AppDbContext _context;
        public PositionManager(AppDbContext context)
        {
            _context = context;
        }

        public List<Position> GetAllPositions()
        {
            return _context.Positions.AsNoTracking().ToList();
        }

        public Position GetPositionByID(int positionID)
        {
            return _context.Positions.FirstOrDefault(e => e.Id.Equals(positionID));
        }

        public void RemovePosition(Position position)
        {
            _context.Positions.Remove(position);
            _context.SaveChanges();
        }

        public void AddPosition(Position position, bool detach = false)
        {
            _context.Positions.Add(position);
            _context.SaveChanges();
            if (detach)
            {
                _context.Entry(position).State = EntityState.Detached;
            }
        }

        public void UpdatePosition(Position position)
        {
            _context.Entry(position).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
