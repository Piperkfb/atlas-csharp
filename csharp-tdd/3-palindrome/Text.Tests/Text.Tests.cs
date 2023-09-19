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
            string pali = "madam";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(true, res);
        }
        [Test]
        public void Spaces()
        {
            string pali = "taco cat";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(true, res);
        }
        [Test]
        public void Punct()
        {
            string pali = "a man, a plan, a canal: panama.";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(true, res);
        }
        [Test]
        public void Cap()
        {
            string pali = "RaCeCar";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(true, res);
        }
        public void wrong()
        {
            string pali = "HelloWorld";
            bool res = Str.IsPalindrome(pali);

            Assert.AreEqual(false, res);
        }
    }
}