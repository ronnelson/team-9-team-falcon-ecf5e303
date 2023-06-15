using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LevelUpGame.levelup;

namespace PositionTest
{
    [TestFixture]
    public class PositionTest
    {
        private Point coordinates;

        [Test]
        public void TestCoordinatesHaveValue()
        {
            Point expectedPoint = new Point(0,0);
            Position actualPoint = new Position(0,0);

            Point expectedValue = new Point(expectedPoint.X, expectedPoint.Y);
            Point actualValue = actualPoint.Coordinates;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestAPosition()
        {
            Point expectedPoint = new Point(5,5);
            Position actualPoint = new Position(5,5);

            Point expectedValue = new Point(expectedPoint.X, expectedPoint.Y);
            Point actualValue = actualPoint.Coordinates;

            Assert.AreEqual(expectedValue, actualValue);
        }

    }

}