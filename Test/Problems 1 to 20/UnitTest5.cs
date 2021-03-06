using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest5
    {
        [SetUp]
        public void Setup()
        {
        }

[TestCase(2, 2)]
[TestCase(10, 2520)]
[TestCase(3, 6)]
[TestCase(4, 12)]
[TestCase(5, 60)]
        [Test]
        public void TestProblem5(int limit, int expected)
        {
            Assert.AreEqual(expected, Problem5.FindSmallestNumberOfMultiplesUpTo(limit));
        }
    }
}

