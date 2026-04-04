using NUnit.Framework;
using System;

[TestFixture]
public class MathOperationsNUnit
{
    private MathOperations math;

    [SetUp]
    public void Setup()
    {
        math = new MathOperations();
    }

    [Test]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
    }

    [Test]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        int result = math.Divide(20, 5);
        Assert.AreEqual(4, result);
    }
}
