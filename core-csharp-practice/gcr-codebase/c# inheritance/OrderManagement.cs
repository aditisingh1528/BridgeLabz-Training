using System;

class Order
{
    public virtual string Status() => "Order Placed";
}

class ShippedOrder : Order
{
    public override string Status() => "Order Shipped";
}

class DeliveredOrder : ShippedOrder
{
    public override string Status() => "Order Delivered";
}

class Program
{
    static void Main()
    {
        Order o = new DeliveredOrder();
        Console.WriteLine(o.Status());
    }
}
