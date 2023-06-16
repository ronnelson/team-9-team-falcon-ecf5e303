using System.Drawing;
using static levelup.GameController;

namespace LevelUpGame.levelup
{
    public class GameMap
    {
        Position[,] Positions;
        public Position StartingPosition = new Position(0,0);
        
        // Game grid boundaries
        private const int MIN_X = 0;
        private const int MAX_X = 9;
        private const int MIN_Y = 0;
        private const int MAX_Y = 9;

        public void Init()
        {
            Positions = new Position[MAX_X - MIN_X + 1, MAX_Y - MIN_Y + 1];

            for (int i = MIN_X; i <= MAX_X; i++)
            {
                for (int j = MIN_Y; j <= MAX_Y; j++)
                {
                    Positions[i, j] = new Position(i, j);
                }
            }
        }

        public Position[,] GetPositions()
        {
            return Positions;
        }

        public Position GetStartingPosition()
        {
            return StartingPosition;
        }

        public Position CalculatePosition(Position startingPosition, DIRECTION direction)
        {
            // ToDo: Implement
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
            return Positions.Length;
        }
    }
}
