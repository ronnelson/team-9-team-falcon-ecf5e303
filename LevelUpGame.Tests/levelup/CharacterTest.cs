using System.Drawing;
using NUnit.Framework;
using LevelUpGame.levelup;
using static levelup.GameController;

namespace LevelUpGame.levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character testObj;

        [SetUp]
        public void SetUp()
        {
           // testObj = new Character();
            testObj = new FakeCharacterClass();
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
        //var character = new Character();
        GameMap gameMap = new GameMap();
        FakeCharacterClass character = new FakeCharacterClass(gameMap);
        character.EnterMap(gameMap);
        Assert.NotNull(character.getGameMap());
       }

       [Test]
       public void EnterMap_Should_Set_Initial_Position()
       {
        var expectedStartingPosition = new Position(0,0);
        //var character = new Character();
        var character = new FakeCharacterClass();
        var gameMap = new GameMap();
        character.EnterMap(gameMap);
        //Assert.AreEqual(character.CurrentPosition.Coordinates,expectedStartingPosition.Coordinates);
        Assert.AreEqual(character.GetPosition().Coordinates,expectedStartingPosition.Coordinates);
       }

       [Test]
       public void GetPosition_Should_Return_Current_Position() 
       {
            var character = new Character();
            var gameMap = new GameMap();
            var expected = new Position(0,0);
            character.EnterMap(gameMap);
            var result = character.GetPosition();

            Assert.AreEqual(result.Coordinates, expected.Coordinates);
       }

       [Test]
       public void Move_Should_Update_Current_Position()
       {
            var direction = DIRECTION.EAST;
            var character = new Character();
            var gameMap = new GameMap();
            character.EnterMap(gameMap);
            var expected = new Position(1,0);

            character.Move(direction);
            var result = character.GetPosition();
            Assert.AreEqual(result.Coordinates, expected.Coordinates);
       }

        [Test]
        public void Move_Should_Increment_MoveCount()
        {
            var direction = DIRECTION.EAST;
            var character = new Character();
            var gameMap = new GameMap();
            character.EnterMap(gameMap);
            var expected = 1;

            character.Move(direction);
            var result = character.MoveCount;
            Assert.AreEqual(result,expected);
        }

    }


}