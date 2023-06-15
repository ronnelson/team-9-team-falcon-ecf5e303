using NUnit.Framework;
using levelup;

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
         Assert.AreEqual(result.Name, expected);
       }

       [Test]
       public void Constructor_Should_Return_DefaultName_When_NoInputs()
       {
        var defaultName = "Mark";
        var result = new Character();
        Assert.AreEqual(result.Name, defaultName);
       }
    }
}