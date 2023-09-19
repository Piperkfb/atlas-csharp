using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class MaxTests
    {
        [Test]
        public void MultipleRange()
        {
            List<int> listy = new List<int> {0, -24, 5, -3, 6};
            int res = Operations.Max(listy);

            Assert.AreEqual(6, res);
        }
        [Test]
        public void Negatives()
        {
            List<int> listy = new List<int> {-15, -3, -7, -30};
            int res = Operations.Max(listy);

            Assert.AreEqual(-3, res);
        }
        [Test]
        public void Positives()
        {   
            List<int> listy = new List<int> {4, 10, 0, 34, 2};
            int res = Operations.Max(listy);

            Assert.AreEqual(34, res);
        }
        [Test]
        public void EmptyList()
        {            
            List<int> listy = null;
            int res = Operations.Max(listy);

            Assert.AreEqual(0, res); 
        }
    }
}