using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static levelup.GameController;

namespace LevelUpGame.levelup
{
    public class GameMap
    {
        Position[][] Positions;
        Position StartingPosition = new Position(0,0);
        int NumPositions = 100;

        private const int MIN_X = 0;
        private const int MAX_X = 9;
        private const int MIN_Y = 0;
        private const int MAX_Y = 9;

        public Position[][] GetPositions()
        {
            throw new NotImplementedException();
        }

        public void CalculatePosition(Position startingPosition, DIRECTION direction)
        {
            throw new NotImplementedException();
        }

        public bool IsPositionValid(Point positionCoordinates)
        {
            // x parameter
            if (positionCoordinates.X < MIN_X || positionCoordinates.X > MAX_X)
            {
                return false;
            }

            // y parameter
            if (positionCoordinates.Y < MIN_Y || positionCoordinates.Y > MAX_Y) 
            { 
                return false; 
            }

            return true;
        }

        public int GetTotalPositions()
        {
            throw new NotImplementedException();
        }
    }
}
