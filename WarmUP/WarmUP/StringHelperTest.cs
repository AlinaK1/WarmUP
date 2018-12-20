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
            Assert.AreEqual("dsdsd", actual);
        }


    }
}
