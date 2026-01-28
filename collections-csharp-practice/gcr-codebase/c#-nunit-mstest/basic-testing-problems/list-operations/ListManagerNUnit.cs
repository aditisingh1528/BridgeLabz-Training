using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerNUnit
{
    private ListManager manager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void AddElement_ValidElement_ElementAdded()
    {
        manager.AddElement(list, 10);
        Assert.Contains(10, list);
    }

    [Test]
    public void RemoveElement_ExistingElement_ElementRemoved()
    {
        list.Add(5);
        list.Add(10);

        manager.RemoveElement(list, 5);
        Assert.IsFalse(list.Contains(5));
    }

    [Test]
    public void GetSize_AfterAddAndRemove_ReturnsCorrectSize()
    {
        manager.AddElement(list, 1);
        manager.AddElement(list, 2);
        manager.RemoveElement(list, 1);

        int size = manager.GetSize(list);
        Assert.AreEqual(1, size);
    }
}
