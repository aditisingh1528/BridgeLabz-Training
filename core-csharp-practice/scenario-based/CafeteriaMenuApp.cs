using System;

public class CafeteriaMenuApp{

    static string[] menuItems =
    {
        "Lime Soda",
        "Iced Tea",
        "Cappuccino",
        "Matcha",
        "Cheese Burger",
        "Margherita Pizza",
        "Chilli Garlic Noodles",
        "Honey Chilli Potato",
        "Red Sauce Pasta",
        "Veg Momos"
    };

    static void Main()
    {
        DisplayMenu();

        Console.WriteLine("Enter the indexes of the items you want to order (e.g. 1,2,3,...): ");
        string input = Console.ReadLine();

        string[] indexes = input.Split(',');

        Console.WriteLine("Your Orders: ");

        foreach (string i in indexes)
        {
            int index = int.Parse(i.Trim());
            string item = GetItemByIndex(index);

            if (item != null) Console.WriteLine("- " + item);

            else Console.WriteLine("- Invalid index: " + index);
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("-----CAFETERIA MENU-----");

        for(int i = 0;i < menuItems.Length; i++){

            Console.WriteLine(i + ". " + menuItems[i]);
        }
    }

    static string GetItemByIndex(int index){
        if (index >= 0 && index < menuItems.Length) return menuItems[index];
        return null;
    }
}