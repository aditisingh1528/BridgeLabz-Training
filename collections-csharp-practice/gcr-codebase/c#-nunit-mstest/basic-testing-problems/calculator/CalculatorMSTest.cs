using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class CalculatorMSTest
{
    private Calculator calculator;

    [TestInitialize]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ValidNumbers_ReturnsSum()
    {
        int result = calculator.Add(8, 2);
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Subtract_ValidNumbers_ReturnsDifference()
    {
        int result = calculator.Subtract(8, 3);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Multiply_ValidNumbers_ReturnsProduct()
    {
        int result = calculator.Multiply(3, 6);
        Assert.AreEqual(18, result);
    }

    [TestMethod]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        int result = calculator.Divide(16, 4);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ThrowsException()
    {
        calculator.Divide(10, 0);
    }
}
