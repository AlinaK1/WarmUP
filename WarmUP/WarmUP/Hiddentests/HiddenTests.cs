using NUnit.Framework;
using System.Linq;
using System;
namespace StringHelper
{
    [TestFixture]
    public class StrigFilterTestsHidden
    {

        [Test  ]
        public void  CheckArgsForNull_Test()

        {
            Assert.Throws<ArgumentNullException>(() => StringOperations.RemoveSymbols(null, 's'));
        }
         
        [Test]
        public void RemoveTest1_Hidden()
        {
            var actual = StringOperations.RemoveSymbols("dsdsd", '!');
            Assert.AreEqual("dsdsd",actual);
        }

        [Test]
        public void RemoveTest2_Hidden()
        {

            var actual = StringOperations.RemoveSymbols("", '!');
            Assert.AreEqual("", actual);
        }

        [Test]
        public void RemoveTest3_Hidden()
        {
            var actual = StringOperations.RemoveSymbols("dsdsd!!asa", '!');
            Assert.AreEqual("dsdsdasa", actual);
        }

        [Test]
        public void RevertString_Hidden()
        {
            var actual = StringOperations.RevertString("qwerty");
            var expected = "ytrewq";
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void RevertString_CheckArgsForNull_Test()
        {
            Assert.Throws<ArgumentNullException>(() => StringOperations.RevertString(null));
        }
    }

}
