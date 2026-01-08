using System;

// Node class to store movie details (Doubly Linked List)
class MovieNode
{
    public string title, director;
    public int year;
    public double rating;
    public MovieNode prev, next;
}

// Movie list class
class MovieList
{
    MovieNode head, tail;

    // Add a movie at the end of the list
    public void AddAtEnd(string t, string d, int y, double r)
    {
        MovieNode node = new MovieNode { title = t, director = d, year = y, rating = r };

        // If list is empty
        if (head == null)
        {
            head = tail = node;
            return;
        }

        // Link new node at the end
        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    // Remove a movie by its title
    public void RemoveByTitle(string t)
    {
        MovieNode temp = head;

        // Traverse the list
        while (temp != null)
        {
            if (temp.title == t)
            {
                // If not first node
                if (temp.prev != null)
                    temp.prev.next = temp.next;
                else
                    head = temp.next;

                // If not last node
                if (temp.next != null)
                    temp.next.prev = temp.prev;
                else
                    tail = temp.prev;

                return;
            }
            temp = temp.next;
        }
    }

    // Display movies from start to end
    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " " + temp.rating);
            temp = temp.next;
        }
    }

    // Display movies from end to start
    public void DisplayReverse()
    {
        MovieNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " " + temp.rating);
            temp = temp.prev;
        }
    }
}
