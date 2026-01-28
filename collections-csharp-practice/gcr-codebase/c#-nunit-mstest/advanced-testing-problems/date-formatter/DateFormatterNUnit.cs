using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterNUnit
{
    private DateFormatter formatter;

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ReturnsFormattedDate()
    {
        string result = formatter.FormatDate("2024-01-15");
        Assert.AreEqual("15-01-2024", result);
    }

    [Test]
    public void FormatDate_InvalidDate_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate("15-01-2024"));
    }

    [Test]
    public void FormatDate_InvalidString_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate("invalid-date"));
    }
}
