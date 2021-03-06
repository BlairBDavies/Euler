using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest11
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblem11()
        {
            Assert.AreEqual(51267216, new Problem11().FindGreatestProductInGrid());
        }

        [TestCase(1, 19, 0)]
        [TestCase(8, 0, 0)]
        [TestCase(89, 4, 7)]
        [Test]
        public void TestProblem11GridParser()
        {
            var arr = new Problem11().ParseGrid();
            Assert.AreEqual(1, arr[19][0]);
            Assert.AreEqual(8, arr[0][0]);
            Assert.AreEqual(89, arr[4][7]);
        }

        [Test]
        public void TestProblem11GridParserAllNumbers()
        {
            var arr = new Problem11().ParseGrid();
            foreach (var row in arr)
            {
                foreach (var cell in row)
                {
                    Assert.IsTrue(cell >= 0 && cell < 100);
                }
            }
        }

        [Test]
        public void TestProblem11SmallGridDiagonal()
        {
            var array = new int[4][];
            array[0] = new int[4] { 4, 1, 1, 1 };
            array[1] = new int[4] { 1, 4, 1, 1 };
            array[2] = new int[4] { 1, 1, 4, 1 };
            array[3] = new int[4] { 1, 1, 1, 4 };
            Assert.AreEqual(4 * 4 * 4 * 4, new Problem11().FindGreatestProductInGrid(array));
        }

        [Test]
        public void TestProblem11SmallGridHorizontal()
        {
            var array = new int[4][];
            array[0] = new int[] { 4, 4, 4, 4 };
            array[1] = new int[] { 1, 1, 1, 1 };
            array[2] = new int[] { 1, 1, 1, 1 };
            array[3] = new int[] { 1, 1, 1, 1 };
            Assert.AreEqual(4 * 4 * 4 * 4, new Problem11().FindGreatestProductInGrid(array));
        }


        [Test]
        public void TestProblem11SmallGridVertical()
        {
            var array = new int[4][];
            array[0] = new int[] { 4, 1, 1, 1 };
            array[1] = new int[] { 4, 1, 1, 1 };
            array[2] = new int[] { 4, 1, 1, 1 };
            array[3] = new int[] { 4, 1, 1, 1 };
            Assert.AreEqual(4 * 4 * 4 * 4, new Problem11().FindGreatestProductInGrid(array));
        }
    }
}

