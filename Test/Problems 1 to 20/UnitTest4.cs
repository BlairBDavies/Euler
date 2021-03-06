using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest4
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 9)]
        [TestCase(2, 9009)]
        [TestCase(3, 906609)]
        [TestCase(4, 99000099)]
        [Test]
        public void TestProblem4(int numDigits, int expected)
        {
            var problemSolver = new Problem4();
            Assert.AreEqual(expected, problemSolver.FindLargestPalindrome(numDigits));
        }
    }
}

