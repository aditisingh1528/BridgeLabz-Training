using NUnit.Framework;

[TestFixture]
public class StringUtilsNUnit
{
    private StringUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new StringUtils();
    }

    [Test]
    public void Reverse_ValidString_ReturnsReversed()
    {
        string result = utils.Reverse("hello");
        Assert.AreEqual("olleh", result);
    }

    [Test]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        bool result = utils.IsPalindrome("Madam");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse()
    {
        bool result = utils.IsPalindrome("hello");
        Assert.IsFalse(result);
    }

    [Test]
    public void ToUpperCase_ValidString_ReturnsUppercase()
    {
        string result = utils.ToUpperCase("hello");
        Assert.AreEqual("HELLO", result);
    }

    [Test]
    public void Reverse_NullString_ReturnsNull()
    {
        Assert.IsNull(utils.Reverse(null));
    }
}
