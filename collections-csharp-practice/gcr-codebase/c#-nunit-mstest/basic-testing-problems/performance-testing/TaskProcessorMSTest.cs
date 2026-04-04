using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TaskProcessorMSTest
{
    private TaskProcessor processor;

    [TestInitialize]
    public void Setup()
    {
        processor = new TaskProcessor();
    }

    [TestMethod]
    [Timeout(2000)]
    public void LongRunningTask_ExceedsTimeout_TestFails()
    {
        processor.LongRunningTask();
    }
}
