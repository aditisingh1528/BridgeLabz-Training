using NUnit.Framework;

[TestFixture]
public class PasswordValidatorNUnit
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void IsValid_ValidPassword_ReturnsTrue()
    {
        bool result = validator.IsValid("Password1");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValid_NoUppercase_ReturnsFalse()
    {
        bool result = validator.IsValid("password1");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValid_NoDigit_ReturnsFalse()
    {
        bool result = validator.IsValid("Password");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValid_ShortPassword_ReturnsFalse()
    {
        bool result = validator.IsValid("Pass1");
        Assert.IsFalse(result);
    }
}
