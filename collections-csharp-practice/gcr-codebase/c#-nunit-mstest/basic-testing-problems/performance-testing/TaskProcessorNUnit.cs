using NUnit.Framework;

[TestFixture]
public class TaskProcessorNUnit
{
    private TaskProcessor processor;

    [SetUp]
    public void Setup()
    {
        processor = new TaskProcessor();
    }

    [Test]
    [Timeout(2000)]
    public void LongRunningTask_ExceedsTimeout_TestFails()
    {
        processor.LongRunningTask();
    }
}
