using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class UserRegistrationMSTest
{
    private UserRegistration registration;

    [TestInitialize]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [TestMethod]
    public void RegisterUser_ValidInputs_ReturnsTrue()
    {
        bool result = registration.RegisterUser("user1", "user1@test.com", "secure1");
        Assert.IsTrue(result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void RegisterUser_InvalidUsername_ThrowsException()
    {
        registration.RegisterUser(null, "user@test.com", "secure1");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void RegisterUser_InvalidEmail_ThrowsException()
    {
        registration.RegisterUser("user", "usertest.com", "secure1");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void RegisterUser_InvalidPassword_ThrowsException()
    {
        registration.RegisterUser("user", "user@test.com", "123");
    }
}
