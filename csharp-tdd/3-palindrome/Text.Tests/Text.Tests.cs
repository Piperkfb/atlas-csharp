using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class PaliTests
    {
        [Test]
        public void Basic()
        {
            string pali = "";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(, res);
        }
        [Test]
        public void Spaces()
        {
            string pali = "";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(, res);
        }
        [Test]
        public void Punct()
        {
            string pali = "";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(, res);
        }
        [Test]
        public void Cap()
        {
            string pali = "";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(, res);
        }
    }
}