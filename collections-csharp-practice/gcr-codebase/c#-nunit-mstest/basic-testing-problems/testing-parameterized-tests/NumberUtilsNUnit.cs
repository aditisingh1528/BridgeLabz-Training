using NUnit.Framework;

[TestFixture]
public class NumberUtilsNUnit
{
    private NumberUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new NumberUtils();
    }

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_MultipleInputs_ReturnsExpectedResult(int input, bool expected)
    {
        bool result = utils.IsEven(input);
        Assert.AreEqual(expected, result);
    }
}
