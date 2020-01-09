using System;
using System.Collections.Generic;
using System.Text;
using Api.Services;
using Api.Enums;
using Api.DTOs;

namespace Api.Controllers
{
    public class PositionController
    {
        private readonly IPositionService _positionService;
        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        public PositionsDTO GetAllPositions()
        {
            try
            {
                var positionsList = _positionService.GetAllPosition();

                var result = new PositionsDTO
                {
                    Positions = positionsList,
                    Status = CollectionGetStatus.Success

                };

                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                var result = new PositionsDTO
                {
                    Status = CollectionGetStatus.Failure
                };

                return result;
            }
        }


    }
}
