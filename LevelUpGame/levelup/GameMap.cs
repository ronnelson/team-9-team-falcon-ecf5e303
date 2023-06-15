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

        public Position[][] GetPositions()
        {
            throw new NotImplementedException();
        }

        public void CalculatePosition(Position startingPosition, DIRECTION direction)
        {
            throw new NotImplementedException();
        }

        public bool isPositionValid(Point positionCoordinates)
        {
            throw new NotImplementedException();
        }

        public int getTotalPositions()
        {
            throw new NotImplementedException();
        }
    }
}
