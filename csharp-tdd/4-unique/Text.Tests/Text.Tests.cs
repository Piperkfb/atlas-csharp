using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class UniqTests
    {
        [Test]
        public void Basic()
        {
            string s = "Heheloo";
            int res = Str.UniqueChar(s);

            Assert.AreEqual(4, res);
        }
        [Test]
        public void NoNonRep()
        {
            string s = "aabbccddee";
            int res = Str.UniqueChar(s);

            Assert.AreEqual(-1, res);
        }
        [Test]
        public void Blank()
        {
            string s = "";
            int res = Str.UniqueChar(s);

            Assert.AreEqual(-1, res);
        }
    }
}