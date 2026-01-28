using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorNUnit
{
    private FileProcessor processor;
    private string filePath;

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();
        filePath = "testfile_nunit.txt";
    }

    [Test]
    public void WriteAndReadFile_ContentMatches()
    {
        processor.WriteToFile(filePath, "Hello NUnit");

        string content = processor.ReadFromFile(filePath);
        Assert.AreEqual("Hello NUnit", content);
    }

    [Test]
    public void WriteToFile_FileExistsAfterWrite()
    {
        processor.WriteToFile(filePath, "Check File");

        Assert.IsTrue(File.Exists(filePath));
    }

    [Test]
    public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
    {
        Assert.Throws<IOException>(() => processor.ReadFromFile("nofile.txt"));
    }

    [TearDown]
    public void Cleanup()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }
}
