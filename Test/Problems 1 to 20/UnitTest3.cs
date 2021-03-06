using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest3
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, 3)]
        [TestCase(3, 9)]
        [TestCase(7, 49)]
        [TestCase(29, 13195)]
        [TestCase(6857, 600851475143L)]
        [Test]
        public void TestProblem3(long expected, long number)
        {
            Assert.AreEqual(expected, Problem3.FindLargestPrimeFactor(number));
        }
    }
}

