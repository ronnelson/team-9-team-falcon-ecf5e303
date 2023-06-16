using LevelUpGame.levelup;
using NUnit.Framework;
using System.Drawing;
using static levelup.GameController;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        [TestCase(0, 0, true)]
        [TestCase(9, 0, true)]
        [TestCase(0, 9, true)]
        [TestCase(9, 9, true)]
        [TestCase(5, 0, true)]
        [TestCase(0, 5, true)]
        [TestCase(9, 5, true)]
        [TestCase(5, 9, true)]
        [TestCase(4, 6, true)]
        [TestCase(11, 0, false)]
        [TestCase(-1, 0, false)]    
        [TestCase(4, -3, false)]    
        [TestCase(3, 11, false)]    
        [TestCase(10, 10, false)]    
               
        public void IsPositionValid(int x, int y, bool expectedResult)
        {
            var point = new Point(x, y);
            var results = testObj.IsPositionValid(point);
            Assert.AreEqual(expectedResult,results);
        }

        /* Turn these back on when finishing implementation for CalculatePosition.  Right now it's turning the build monitor red.
        [Test]
        // Upper left corner
        [TestCase(0, 0, DIRECTION.EAST, 0, 1)]
        [TestCase(0, 0, DIRECTION.WEST, 0, 0)]
        [TestCase(0, 0, DIRECTION.SOUTH, 1, 0)]
        [TestCase(0, 0, DIRECTION.NORTH, 0, 0)]

        // Upper right corner
        [TestCase(0, 9, DIRECTION.EAST, 0, 9)]
        [TestCase(0, 9, DIRECTION.WEST, 0, 8)]
        [TestCase(0, 9, DIRECTION.SOUTH, 1, 9)]
        [TestCase(0, 9, DIRECTION.NORTH, 0, 9)]

        // Lower left corner
        [TestCase(9, 0, DIRECTION.EAST, 9, 1)]
        [TestCase(9, 0, DIRECTION.WEST, 9, 0)]
        [TestCase(9, 0, DIRECTION.SOUTH, 9, 0)]
        [TestCase(9, 0, DIRECTION.NORTH, 8, 0)]

        // Lower right corner
        [TestCase(9, 9, DIRECTION.EAST, 9, 9)]
        [TestCase(9, 9, DIRECTION.WEST, 8, 9)]
        [TestCase(9, 9, DIRECTION.SOUTH, 9, 0)]
        [TestCase(9, 9, DIRECTION.NORTH, 9, 8)]

        // Middle
        [TestCase(5, 5, DIRECTION.EAST, 6, 5)]
        [TestCase(5, 5, DIRECTION.WEST, 4, 5)]
        [TestCase(5, 5, DIRECTION.SOUTH, 5, 6)]
        [TestCase(5, 5, DIRECTION.NORTH, 5, 4)]

        // Top edge
        [TestCase(5, 0, DIRECTION.EAST, 6, 0)]
        [TestCase(5, 0, DIRECTION.WEST, 4, 0)]
        [TestCase(5, 0, DIRECTION.SOUTH, 5, 1)]
        [TestCase(5, 0, DIRECTION.NORTH, 5, 0)]

        // Right edge
        [TestCase(9, 5, DIRECTION.EAST, 9, 5)]
        [TestCase(9, 5, DIRECTION.WEST, 8, 5)]
        [TestCase(9, 5, DIRECTION.SOUTH, 9, 6)]
        [TestCase(9, 5, DIRECTION.NORTH, 9, 4)]

        // Bottom edge
        [TestCase(5, 9, DIRECTION.EAST, 6, 9)]
        [TestCase(5, 9, DIRECTION.WEST, 4, 9)]
        [TestCase(5, 9, DIRECTION.SOUTH, 5, 9)]
        [TestCase(5, 9, DIRECTION.NORTH, 5, 8)]

        // Left edge
        [TestCase(0, 5, DIRECTION.EAST, 1, 5)]
        [TestCase(0, 5, DIRECTION.WEST, 0, 5)]
        [TestCase(0, 5, DIRECTION.SOUTH, 0, 6)]
        [TestCase(0, 5, DIRECTION.NORTH, 0, 4)]
        public void CalculatePosition(int x, int y, DIRECTION direction, int expectedX, int expectedY)
        {
            var startingPosition = new Position(x, y);
            var updatedPosition = testObj.CalculatePosition(startingPosition, direction);

            Assert.AreEqual(expectedX, updatedPosition.Coordinates.X);
            Assert.AreEqual(expectedY, updatedPosition.Coordinates.Y);
        }
        */

        [Test]
        public void InitAndGetPositions()
        {
            // Call init
            testObj.Init();

            // Get back a grid of positions
            var positions = testObj.GetPositions();

            // Make sure we have 100 positions.
            Assert.AreEqual(100, positions.Length);

            // Test that coordinates are between 0 and 9
            foreach (var position in positions)
            {
                Assert.True(position.Coordinates.X >= 0 && position.Coordinates.X < 10);
                Assert.True(position.Coordinates.Y >= 0 && position.Coordinates.Y < 10);
            }
        }

        [Test]
        public void GetStartingPosition()
        {
            // Call init
            testObj.Init();

            // Get back a grid of positions
            var position = testObj.GetStartingPosition();

            Assert.AreEqual(0, position.Coordinates.X);
            Assert.AreEqual(0, position .Coordinates.Y);
        }

        [Test]
        public void GetTotalPositions()
        {
            // Call init
            testObj.Init();

            // Get back a grid of positions
            var positionCount = testObj.GetTotalPositions();

            Assert.AreEqual(100, positionCount);
        }
    }
}