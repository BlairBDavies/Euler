using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest12
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(60, 12)]
        [TestCase(76576500, 500)]
        [Test]
        public void TestProblem12(int number, int divisors)
        {
            var result = new Problem12().FindTriangleNumber(divisors);
            Assert.AreEqual(result, number);
        }
    }
}

