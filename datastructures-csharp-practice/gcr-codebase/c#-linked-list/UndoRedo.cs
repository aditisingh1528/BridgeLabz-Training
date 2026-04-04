using System;

// Node class to store each text state
class TextNode
{
    public string text;
    public TextNode prev, next;
}

// Text editor class using Doubly Linked List
class TextEditor
{
    TextNode current;

    // Add a new text state
    public void AddState(string t)
    {
        TextNode node = new TextNode { text = t };

        // Link new state with current state
        if (current != null)
        {
            current.next = node;
            node.prev = current;
        }

        // Move current to new state
        current = node;
    }

    // Undo: move to previous state
    public void Undo()
    {
        if (current != null && current.prev != null)
            current = current.prev;
    }

    // Redo: move to next state
    public void Redo()
    {
        if (current != null && current.next != null)
            current = current.next;
    }

    // Display current text
    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.text);
    }
}
