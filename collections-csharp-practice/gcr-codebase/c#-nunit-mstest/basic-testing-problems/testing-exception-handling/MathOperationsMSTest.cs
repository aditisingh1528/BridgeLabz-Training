using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class MathOperationsMSTest
{
    private MathOperations math;

    [TestInitialize]
    public void Setup()
    {
        math = new MathOperations();
    }

    [TestMethod]
    [ExpectedException(typeof(ArithmeticException))]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        math.Divide(10, 0);
    }

    [TestMethod]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        int result = math.Divide(30, 6);
        Assert.AreEqual(5, result);
    }
}
