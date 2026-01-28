using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class ListManagerMSTest
{
    private ListManager manager;
    private List<int> list;

    [TestInitialize]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [TestMethod]
    public void AddElement_ValidElement_ElementAdded()
    {
        manager.AddElement(list, 20);
        Assert.IsTrue(list.Contains(20));
    }

    [TestMethod]
    public void RemoveElement_ExistingElement_ElementRemoved()
    {
        list.Add(7);
        list.Add(14);

        manager.RemoveElement(list, 7);
        Assert.IsFalse(list.Contains(7));
    }

    [TestMethod]
    public void GetSize_ListWithElements_ReturnsCorrectSize()
    {
        manager.AddElement(list, 3);
        manager.AddElement(list, 6);

        int size = manager.GetSize(list);
        Assert.AreEqual(2, size);
    }
}
