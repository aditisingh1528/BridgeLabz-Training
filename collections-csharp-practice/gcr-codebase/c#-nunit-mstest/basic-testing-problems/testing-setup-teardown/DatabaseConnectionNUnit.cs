using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionNUnit
{
    private DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [Test]
    public void Connect_AfterSetup_IsConnectedTrue()
    {
        Assert.IsTrue(db.IsConnected);
    }

    [Test]
    public void Connection_RemainsActive_DuringTest()
    {
        Assert.AreEqual(true, db.IsConnected);
    }

    [TearDown]
    public void TearDown()
    {
        db.Disconnect();
    }
}
