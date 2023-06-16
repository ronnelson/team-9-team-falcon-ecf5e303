using NUnit.Framework;
using LevelUpGame.levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        [Test]
       public void Constructor_Should_Return_GivenInput()
       {
         var expected = "Bill";
         var result = new Character(expected);
         Assert.AreEqual(result.GetName(), expected);
       }

       [Test]
       public void Constructor_Should_Return_DefaultName_When_NoInputs()
       {
        var defaultName = "Mark";
        var result = new Character();
        Assert.AreEqual(result.GetName(), defaultName);
       }

       [Test]
       public void GetName_Should_Return_Name() {
        var name = "Bob";
        var character = new Character(name);
        var result = character.GetName();
        Assert.AreEqual(result,name);
       }

       [Test]
       public void EnterMap_Should_Set_Initial_Map()
       {
        var character = new Character();
        var gameMap = new GameMap();
        character.EnterMap(gameMap);
        Assert.NotNull(character.GameMap);
       }

       [Test]
       public void EnterMap_Should_Set_Initial_Position()
       {
        var expectedStartingPosition = new Point(0,0);
        var character = new Character();
        var gameMap = new GameMap();
        character.EnterMap(gameMap);
        Assert.AreEqual(character.Position.Coordinates,expectedStartingPosition);
       }

    //    [Test]
    //    public void GetCurrentPosition_Should_Return_Current_Position() 
    //    {
    //         var character = new Character();
    //         var gameMap = new GameMap();
    //         Assert.AreEqual(gameMap.StartingPosition);
    //    }
    }

}