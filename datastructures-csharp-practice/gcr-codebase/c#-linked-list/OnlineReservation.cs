using System;

// Node class to represent each ticket (Circular Linked List)
class TicketNode
{
    public int ticketId;
    public string customerName;
    public string movieName;
    public string seatNumber;
    public DateTime bookingTime;
    public TicketNode next;
}

// Ticket reservation system
class TicketReservation
{
    TicketNode head; // First ticket in circular list

    // Add a new ticket at the end
    public void AddTicket(int id, string customer, string movie, string seat)
    {
        TicketNode node = new TicketNode
        {
            ticketId = id,
            customerName = customer,
            movieName = movie,
            seatNumber = seat,
            bookingTime = DateTime.Now
        };

        // If list is empty
        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }

        // Traverse to last node
        TicketNode temp = head;
        while (temp.next != head)
            temp = temp.next;

        temp.next = node;
        node.next = head;
    }

    // Remove a ticket by Ticket ID
    public void RemoveTicket(int id)
    {
        if (head == null) return;

        // If only one node
        if (head.ticketId == id && head.next == head)
        {
            head = null;
            return;
        }

        // If head needs to be removed
        if (head.ticketId == id)
        {
            TicketNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = head.next;
            head = head.next;
            return;
        }

        // Remove non-head node
        TicketNode curr = head;
        while (curr.next != head && curr.next.ticketId != id)
            curr = curr.next;

        if (curr.next.ticketId == id)
            curr.next = curr.next.next;
    }

    // Display all booked tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode temp = head;
        do
        {
            Console.WriteLine(
                temp.ticketId + " | " +
                temp.customerName + " | " +
                temp.movieName + " | " +
                temp.seatNumber + " | " +
                temp.bookingTime
            );
            temp = temp.next;
        } while (temp != head);
    }

    // Search ticket by customer name or movie name
    public void Search(string value)
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            if (temp.customerName == value || temp.movieName == value)
            {
                Console.WriteLine(
                    temp.ticketId + " " +
                    temp.customerName + " " +
                    temp.movieName + " " +
                    temp.seatNumber
                );
            }
            temp = temp.next;
        } while (temp != head);
    }

    // Count total booked tickets
    public int TotalTickets()
    {
        if (head == null) return 0;

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.next;
        } while (temp != head);

        return count;
    }
}
