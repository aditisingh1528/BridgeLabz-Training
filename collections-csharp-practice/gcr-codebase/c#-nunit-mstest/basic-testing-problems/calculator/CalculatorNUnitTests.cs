using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorNUnit
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ValidNumbers_ReturnsSum()
    {
        int result = calculator.Add(10, 5);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Subtract_ValidNumbers_ReturnsDifference()
    {
        int result = calculator.Subtract(10, 5);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Multiply_ValidNumbers_ReturnsProduct()
    {
        int result = calculator.Multiply(4, 5);
        Assert.AreEqual(20, result);
    }

    [Test]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        int result = calculator.Divide(20, 4);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}
