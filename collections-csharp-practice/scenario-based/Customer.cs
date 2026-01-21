public class Customer
{
    // Stores unique ID of the customer
    private int customerId;

    // Stores list of items bought by the customer
    private string[] items;

    // Constructor to initialize customer ID and items
    public Customer(int customerId, string[] items)
    {
        this.customerId = customerId; // Assign customer ID
        this.items = items; // Assign items array
    }

    // Returns the customer ID
    public int GetCustomerId()
    {
        return customerId;
    }

    // Returns the list of items
    public string[] GetItems()
    {
        return items;
    }
}