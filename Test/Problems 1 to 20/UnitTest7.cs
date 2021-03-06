using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest7
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(5, 11)]
        [TestCase(6, 13)]
        [TestCase(10, 29)]
        [TestCase(10001, 104743)]
        [Test]
        public void TestProblem7(int location, long expected)
        {
            Assert.AreEqual(expected, Problem7.FindNthPrime(location));
        }
    }
}

