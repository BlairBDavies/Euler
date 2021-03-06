using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest2
    {

        private Problem2 problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem2();
        }

        [TestCase(2, 3)]
        [TestCase(2, 8)]
        [TestCase(10, 9)]
        [TestCase(44, 35)]
        [TestCase(4613732, 40000000)]
        [Test]
        public void TestProblem2(int expected, int max)
        {
            Assert.AreEqual(expected, problem.SumEvenFibonacciUnder(max));
        }
    }
}

