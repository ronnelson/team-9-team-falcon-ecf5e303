using NUnit.Framework;
using levelup;
using LevelUpGame.levelup;
using System.Drawing;

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
    }
}