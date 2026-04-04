using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class DateFormatterMSTest
{
    private DateFormatter formatter;

    [TestInitialize]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [TestMethod]
    public void FormatDate_ValidDate_ReturnsFormattedDate()
    {
        string result = formatter.FormatDate("2023-12-05");
        Assert.AreEqual("05-12-2023", result);
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void FormatDate_InvalidDate_ThrowsFormatException()
    {
        formatter.FormatDate("05/12/2023");
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void FormatDate_EmptyString_ThrowsFormatException()
    {
        formatter.FormatDate("");
    }
}
