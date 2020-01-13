using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Api.Managers
{
    public interface IPositionManager
    {
        public Position GetPositionByID(int positionID);
        public List<Position> GetAllPositions();
        public void RemovePosition(Position position);
        public void AddPosition(Position position);

        public void UpdatePosition(Position position);
    }
}
