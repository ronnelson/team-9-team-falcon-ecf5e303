
using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }

        [Test]
        public void CreateCharacter_Should_Create_A_Character()
        {
            const string name = "Hi!";

            // Call create character
            testObj.CreateCharacter(name);

            // Test the character that was created
            var created = testObj.GetCharacter();
            Assert.AreEqual(name, created.GetName());
        }

        [Test]
        public void StartGame_Character_Exists()
        {
            testObj.CreateCharacter();
            testObj.StartGame();
            var character = testObj.GetCharacter();

            Assert.NotNull(character.GameMap);
        }
    }
}