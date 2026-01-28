using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PasswordValidatorMSTest
{
    private PasswordValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [TestMethod]
    public void IsValid_ValidPassword_ReturnsTrue()
    {
        bool result = validator.IsValid("Secure123");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsValid_NoUppercase_ReturnsFalse()
    {
        bool result = validator.IsValid("secure123");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_NoDigit_ReturnsFalse()
    {
        bool result = validator.IsValid("SecurePass");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_NullPassword_ReturnsFalse()
    {
        bool result = validator.IsValid(null);
        Assert.IsFalse(result);
    }
}
