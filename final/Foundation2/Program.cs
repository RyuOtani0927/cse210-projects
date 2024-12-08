using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        Order order1 = new Order("Emily Carter", "742 Evergreen Terrace", "Springfield", "Illinois","United States");
        order1.AddProduct("Wireless Mouse", "WM-1001",25.25,4);
        order1.AddProduct("Gaming Keyboard","GK-2003",60.00,1);
        order1.AddProduct("Noise-Cancelling Headphones","NC-3010",149.99,2);
        order1.DisplayOrderInfo();

        Order order2 = new Order("Jacob Müller", "12 Bahnhofstrasse", "Zurich", "Zurich", "Switzerland");
        order2.AddProduct("Laptop Stand","LS-5025", 35.50,2);
        order2.AddProduct("External Hard Drive (1TB)", "EH-6015",90.00,1);
        order2.AddProduct("LED Desk Lamp", "DL-10015",29.99,2);
        order2.DisplayOrderInfo();

    }
}