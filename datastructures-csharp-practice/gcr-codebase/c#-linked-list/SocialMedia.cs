using System;

// Node class to represent a user
class UserNode
{
    public int id;
    public string name;
    public UserNode next;
}

// Social media class using Singly Linked List
class SocialMedia
{
    UserNode head;

    // Method to add a new user at the beginning
    public void AddUser(int id, string name)
    {
        UserNode node = new UserNode { id = id, name = name };
        node.next = head;
        head = node;
    }

    // Method to search a user by ID
    public void SearchUser(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.id == id)
            {
                Console.WriteLine(temp.name); // Print user name if found
                return;
            }
            temp = temp.next;
        }
    }
}
