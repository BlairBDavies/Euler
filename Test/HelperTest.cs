using System.Linq;
using NUnit.Framework;
using Shared;

[TestFixture]
public class HelperTest
{

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

    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(17, 19)]
    [Test]

    public void NextPrimeTest(int input, int expected)
    {
        Assert.AreEqual(Helper.GetNextPrime(input), expected);
    }

    [TestCase(4, new int[] { 2, 2 })]
    [TestCase(9, new int[] { 3, 3 })]
    [TestCase(17, new int[] { 17 })]
    [TestCase(15, new int[] { 3, 5 })]
    [TestCase(1440, new int[] { 2, 2, 2, 2, 2, 3, 3, 5 })]
    [Test]
    public void FindPrimeMultiplesTest(long input, int[] expected)
    {
        var result = Helper.FindPrimeMultiples(input);
        Assert.AreEqual(expected.Length, result.Length);
        foreach (var a in result)
        {
            Assert.IsTrue(expected.Any(x => x == a));
        }
        foreach (var b in expected)
        {
            Assert.IsTrue(result.Any(x => x == b));
        }
    }
}