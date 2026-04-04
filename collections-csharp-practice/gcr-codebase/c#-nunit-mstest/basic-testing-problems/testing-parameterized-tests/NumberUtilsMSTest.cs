using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class NumberUtilsMSTest
{
    private NumberUtils utils;

    [TestInitialize]
    public void Setup()
    {
        utils = new NumberUtils();
    }

    [DataTestMethod]
    [DataRow(2, true)]
    [DataRow(4, true)]
    [DataRow(6, true)]
    [DataRow(7, false)]
    [DataRow(9, false)]
    public void IsEven_MultipleInputs_ReturnsExpectedResult(int input, bool expected)
    {
        bool result = utils.IsEven(input);
        Assert.AreEqual(expected, result);
    }
}
