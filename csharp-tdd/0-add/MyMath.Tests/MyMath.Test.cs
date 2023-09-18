using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void PosPos()
        {
            int a = 10;
            int b = 15;
            int res = Operations.Add(a, b);

            Assert.AreEqual(25, res);
        }
        [Test]
        public void NegNeg()
        {
            int a = -15;
            int b = -5;
            int res = Operations.Add(a, b);

            Assert.AreEqual(-20, res);
        }
        [Test]
        public void PosNeg()
        {
            int a = 20;
            int b = -5;
            int res = Operations.Add(a, b);

            Assert.AreEqual(15, res);
        }
        [Test]
        public void Zero()
        {
            int a = 0;
            int b = 20;
            int res = Operations.Add(a, b);

            Assert.AreEqual(20, res);
        }
    }
}