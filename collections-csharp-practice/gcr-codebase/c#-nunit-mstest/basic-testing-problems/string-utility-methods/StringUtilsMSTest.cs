using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringUtilsMSTest
{
    private StringUtils utils;

    [TestInitialize]
    public void Setup()
    {
        utils = new StringUtils();
    }

    [TestMethod]
    public void Reverse_ValidString_ReturnsReversed()
    {
        string result = utils.Reverse("world");
        Assert.AreEqual("dlrow", result);
    }

    [TestMethod]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        bool result = utils.IsPalindrome("Level");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse()
    {
        bool result = utils.IsPalindrome("test");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ToUpperCase_ValidString_ReturnsUppercase()
    {
        string result = utils.ToUpperCase("dotnet");
        Assert.AreEqual("DOTNET", result);
    }

    [TestMethod]
    public void ToUpperCase_NullString_ReturnsNull()
    {
        Assert.IsNull(utils.ToUpperCase(null));
    }
}
