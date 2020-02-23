using NUnit.Framework;

[TestFixture]
public class HelperTest {

    [SetUp]
        public void Setup()
        {
        }


        [TestCase("0000", "0000")]
        [TestCase("asdf", "fdsa")]
        [TestCase("As34", "43sA")]
        [TestCase("1234", "4321")]
        [Test]
        public void StringReverseTest(string attempt, string expected)
        {
            var str = StringHelper.ReverseString(attempt);
            Assert.AreEqual(expected, str);
        }

        [TestCase(1234, false)]
        [TestCase(1, true)]
        [TestCase(11, true)]
        [TestCase(1234321, true)]
        [TestCase(9998, false)]
        [Test]
        public void NumberIsPalindromTest(int attempt, bool expected)
        {
            var result = NumberStringHelper.IsNumberPalindrome(attempt);
            Assert.AreEqual(expected, result);
        }
}