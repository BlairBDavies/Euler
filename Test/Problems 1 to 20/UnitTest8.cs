using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest8
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4, 5832)]
        [TestCase(3, 648)]
        [TestCase(13, 2091059712)]
        [Test]
        public void TestProblem8(int digits, long expected)
        {
            Assert.AreEqual(expected, Problem8.FindAdjacentProduct(digits));
        }
    }
}

