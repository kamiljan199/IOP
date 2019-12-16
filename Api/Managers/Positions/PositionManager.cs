using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Data.Context;
using System.Linq;

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
            return _context.Positions.ToList();
        }

        public Position GetPositionByID(int positionID)
        {
            return _context.Positions.FirstOrDefault(e => e.Id.Equals(positionID));
        }
    }
}
