using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest10
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 17)]
        [TestCase(11, 17)]
        [TestCase(12, 28)]
        [TestCase(14, 41)]
        [TestCase(2000000, 28)]
        [Test]
        public void TestProblem10(int limit, long expected)
        {
            Assert.AreEqual(expected, Problem10.FindSumOfPrimesUnder(limit));
        }
    }
}

