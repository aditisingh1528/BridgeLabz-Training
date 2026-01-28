using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TemperatureConverterMSTest
{
    private TemperatureConverter converter;

    [TestInitialize]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [TestMethod]
    public void CelsiusToFahrenheit_TwentyFiveCelsius_Returns77()
    {
        double result = converter.CelsiusToFahrenheit(25);
        Assert.AreEqual(77, result);
    }

    [TestMethod]
    public void FahrenheitToCelsius_SeventySevenFahrenheit_Returns25()
    {
        double result = converter.FahrenheitToCelsius(77);
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void CelsiusToFahrenheit_NegativeCelsius_ReturnsCorrectValue()
    {
        double result = converter.CelsiusToFahrenheit(-40);
        Assert.AreEqual(-40, result);
    }
}
