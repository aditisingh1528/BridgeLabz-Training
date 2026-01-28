using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationNUnit
{
    private UserRegistration registration;

    [SetUp]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInputs_ReturnsTrue()
    {
        bool result = registration.RegisterUser("aniket", "aniket@mail.com", "pass123");
        Assert.IsTrue(result);
    }

    [Test]
    public void RegisterUser_InvalidUsername_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("", "user@mail.com", "pass123"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("user", "invalidmail", "pass123"));
    }

    [Test]
    public void RegisterUser_InvalidPassword_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("user", "user@mail.com", "123"));
    }
}
