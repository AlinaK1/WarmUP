using NUnit.Framework;
using System;
namespace StringHelper
{
    [TestFixture]
    public class StrigFilterTest
    {


        [Test]
        public void RemoveTest()
        {
            var actual = StringOperations.RemoveSymbols("dsdsd", '!');
            var expected = "dsdsd";
            Assert.AreEqual(expected,actual);
        }


    }
}
