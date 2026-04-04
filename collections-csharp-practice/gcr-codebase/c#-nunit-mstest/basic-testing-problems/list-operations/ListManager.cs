using System;
using System.Collections.Generic;

public class ListManager
{
    //method to add element to list
    public void AddElement(List<int> list, int element)
    {
        list.Add(element);
    }

    //method to remove element from list
    public void RemoveElement(List<int> list, int element)
    {
        list.Remove(element);
    }

    //method to get size of list
    public int GetSize(List<int> list)
    {
        return list.Count;
    }
}
