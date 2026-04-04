using System;

// Node class to store student details
class StudentNode
{
    public int roll;
    public string name;
    public int age;
    public char grade;
    public StudentNode next;
}

// Linked list class to manage students
class StudentList
{
    StudentNode head;

    // Add a student at the end of the list
    public void AddAtEnd(int r, string n, int a, char g)
    {
        StudentNode node = new StudentNode { roll = r, name = n, age = a, grade = g };

        // If list is empty
        if (head == null)
        {
            head = node;
            return;
        }

        // Traverse to the last node
        StudentNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = node;
    }

    // Delete a student using roll number
    public void DeleteByRoll(int r)
    {
        if (head == null) return;

        // If first student matches
        if (head.roll == r)
        {
            head = head.next;
            return;
        }

        // Find the previous node
        StudentNode temp = head;
        while (temp.next != null && temp.next.roll != r)
            temp = temp.next;

        // Remove the node
        if (temp.next != null)
            temp.next = temp.next.next;
    }

    // Search student by roll number
    public void Search(int r)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.roll == r)
            {
                Console.WriteLine(temp.name + " Grade: " + temp.grade);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found");
    }

    // Update grade of a student
    public void UpdateGrade(int r, char g)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.roll == r)
            {
                temp.grade = g;
                return;
            }
            temp = temp.next;
        }
    }

    // Display all students
    public void Display()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.roll + " " + temp.name + " " + temp.grade);
            temp = temp.next;
        }
    }
}
