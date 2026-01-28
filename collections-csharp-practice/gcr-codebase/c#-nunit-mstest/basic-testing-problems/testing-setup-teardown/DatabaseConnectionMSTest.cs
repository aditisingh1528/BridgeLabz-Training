using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class DatabaseConnectionMSTest
{
    private DatabaseConnection db;

    [TestInitialize]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TestMethod]
    public void Connect_AfterInitialize_IsConnectedTrue()
    {
        Assert.IsTrue(db.IsConnected);
    }

    [TestMethod]
    public void Connection_RemainsActive_DuringTest()
    {
        Assert.AreEqual(true, db.IsConnected);
    }

    [TestCleanup]
    public void Cleanup()
    {
        db.Disconnect();
    }
}
