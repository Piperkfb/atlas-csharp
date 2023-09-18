using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class DivTests
    {
        [Test]
        public void PosByTwo()
        {
            int[,] matrix = new int[,] {{15, 20}, {10, 30}, {7, 8}};
            int n = 2;

            int[,] res = Matrix.Divide(matrix, n);

            Assert.AreEqual(new int[,] {{7, 10}, {5, 15}, {3, 4}}, res);
        }
        [Test]
        public void Zero()
        {
            int[,] matrix = new int[,] {{15, 20}, {10, 30}, {7, 8}};
            int n = 0;

            int[,] res = Matrix.Divide(matrix, n);

            Assert.AreEqual(null, res);
        }
        [Test]
        public void IsNull()
        {
            int[,] matrix = null;
            int n = 5;

            int[,] res = Matrix.Divide(matrix, n);

            Assert.AreEqual(null, res);
        }
    }
}