using NUnit.Framework;

[TestFixture]
public class TemperatureConverterNUnit
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ZeroCelsius_Returns32()
    {
        double result = converter.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result);
    }

    [Test]
    public void CelsiusToFahrenheit_HundredCelsius_Returns212()
    {
        double result = converter.CelsiusToFahrenheit(100);
        Assert.AreEqual(212, result);
    }

    [Test]
    public void FahrenheitToCelsius_ThirtyTwoFahrenheit_ReturnsZero()
    {
        double result = converter.FahrenheitToCelsius(32);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void FahrenheitToCelsius_TwoTwelveFahrenheit_ReturnsHundred()
    {
        double result = converter.FahrenheitToCelsius(212);
        Assert.AreEqual(100, result);
    }
}
