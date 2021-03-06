using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest6
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1)]
        [TestCase(2, 5)]
        [TestCase(3, 14)]
        [TestCase(10, 385)]
        [Test]
        public void TestFindSumOfSquares(int limit, int expected)
        {
            Assert.AreEqual(expected, Problem6.FindSumOfSquares(limit));
        }

        [TestCase(1, 1)]
        [TestCase(2, 9)]
        [TestCase(3, 36)]
        [TestCase(10, 3025)]
        [Test]
        public void TestFindSquareOfSum(int limit, int expected)
        {
            Assert.AreEqual(expected, Problem6.FindSquareOfSum(limit));
        }
        
        [TestCase(1, 0)]
        [TestCase(2, 4)]
        [TestCase(3, 22)]
        [TestCase(10, 2640)]
        [TestCase(100, 25164150)]
        [Test]
        public void TestFindDifference(int limit, int expected)
        {
            Assert.AreEqual(expected, Problem6.FindDifference(limit));
        }
    }
}

