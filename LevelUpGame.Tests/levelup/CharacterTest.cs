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
       public void GetName_Should_return_GivenInput()
       {
         var expected = "Bill";
         var results = new Character(expected);
         Assert.AreEqual(results.Name, expected);
       }
    }
}