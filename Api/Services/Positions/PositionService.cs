using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionManager _positionManager;

        public PositionService(IPositionManager positionManager)
        {
            _positionManager = positionManager;
        }

        public List<Position> GetAllPosition()
        {
            var positionsList = _positionManager.GetAllPositions();
            if (positionsList.Count.Equals(0))
            {
                throw new Exception($"No position has been found");
            }
            return positionsList;
        }

        public Position GetPositionByID(int positionID)
        {
            return _positionManager.GetPositionByID(positionID);
        }

        public void RemovePosition(Position position)
        {
            _positionManager.RemovePosition(position);
        }

        public void AddPosition(Position position, bool detach = false)
        {
            _positionManager.AddPosition(position, detach);
        }

        public void UpdatePosition(Position position)
        {
            _positionManager.UpdatePosition(position);
        }
    }
}
