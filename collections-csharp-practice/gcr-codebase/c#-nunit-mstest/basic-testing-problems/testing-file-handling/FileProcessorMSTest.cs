using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

[TestClass]
public class FileProcessorMSTest
{
    private FileProcessor processor;
    private string filePath;

    [TestInitialize]
    public void Setup()
    {
        processor = new FileProcessor();
        filePath = "testfile_mstest.txt";
    }

    [TestMethod]
    public void WriteAndReadFile_ContentMatches()
    {
        processor.WriteToFile(filePath, "Hello MSTest");

        string content = processor.ReadFromFile(filePath);
        Assert.AreEqual("Hello MSTest", content);
    }

    [TestMethod]
    public void WriteToFile_FileExistsAfterWrite()
    {
        processor.WriteToFile(filePath, "File Exists");

        Assert.IsTrue(File.Exists(filePath));
    }

    [TestMethod]
    [ExpectedException(typeof(IOException))]
    public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
    {
        processor.ReadFromFile("missingfile.txt");
    }

    [TestCleanup]
    public void Cleanup()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }
}
