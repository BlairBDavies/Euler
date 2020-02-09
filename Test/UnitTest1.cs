using NUnit.Framework;
using Euler;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Development confirmation
            Assert.AreEqual(0, Problem1.SumOfMultiples(3));
            Assert.AreEqual(3, Problem1.SumOfMultiples(4));
            Assert.AreEqual(3, Problem1.SumOfMultiples(5));
            Assert.AreEqual(8, Problem1.SumOfMultiples(6));
            Assert.AreEqual(14, Problem1.SumOfMultiples(7));
            Assert.AreEqual(14, Problem1.SumOfMultiples(9));
            Assert.AreEqual(23, Problem1.SumOfMultiples(10));
        }

        [Test]
        public void Test2()
        {
            //Problem confirmation
            Assert.AreEqual(233168, Problem1.SumOfMultiples(1000));
        }
    }
}