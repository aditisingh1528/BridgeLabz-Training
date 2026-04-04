using System;

// Node class to represent each task
class TaskNode
{
    public int id;
    public string name;
    public int priority;
    public TaskNode next;
}

// Scheduler class using Circular Linked List
class TaskScheduler
{
    TaskNode head;
	
	// Method to add a new task
    public void AddTask(int id, string name, int p)
    {
        TaskNode node = new TaskNode { id = id, name = name, priority = p };
		
		// If list is empty, point node to itself
        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }
		
		// Traverse to the last node
        TaskNode temp = head;
        while (temp.next != head)
            temp = temp.next;

		// Insert new node at the end
        temp.next = node;
        node.next = head;
    }
	
	// Method to display all tasks
    public void Display()
    {
		// If list is empty, nothing to display
        if (head == null) return;
        TaskNode temp = head;
		
		// Traverse circular linked list
        do
        {
            Console.WriteLine(temp.id + " " + temp.name);
            temp = temp.next;
        } while (temp != head);
    }
}
