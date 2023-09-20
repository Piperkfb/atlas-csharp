using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class CamelTests
    {
        [Test]
        public void Blank()
        {
            string s = "";
            int res = Str.CamelCase(s);

            Assert.AreEqual(0, res);
        }
        [Test]
        public void OneWord()
        {
            string s = "hewwo";
            int res = Str.CamelCase(s);

            Assert.AreEqual(1, res);
        }
        [Test]
        public void TwoWords()
        {
            string s = "heeow Hope";
            int res = Str.CamelCase(s);

            Assert.AreEqual(2, res)
        }
        [Test]
        public void MultipleWords()
        {
            string s = "hewwo How Are You";
            int res = Str.CamelCase(s);

            Assert.AreEqual(4, res);
        }
    }
}