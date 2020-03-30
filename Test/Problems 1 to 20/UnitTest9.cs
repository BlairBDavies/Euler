using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest9
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblem9()
        {
            var answer = new Problem9().FindTriplet();
            Assert.AreEqual(31875000, answer);
        }
    }
}

