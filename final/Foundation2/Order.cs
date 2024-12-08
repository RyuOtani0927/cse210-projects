public class Order
{
    private List<Product> _productClassList = new();
    private Customer _customerClass = new();

    public Order(Customer customer)
    {
        _customerClass = customer;
    }
    public Order(string name, Address address)
    {
        _customerClass = new Customer(name,address);
    }
    public Order (string name, string street, string city, string state, string country)
    {
        _customerClass = new Customer(name, street, city, state, country);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        _productClassList.Add(new Product(name, id, price, quantity));
    }
    public double GetOrderTotalCost()
    {
        double totalCost = 0;

        foreach (Product productClass in _productClassList)
        {
            totalCost = totalCost + productClass.GetProductTotalCost();
        }
        if (_customerClass.GetIfFromUSA())
        {
            totalCost = totalCost + 5;
        }
        else
        {
            totalCost = totalCost + 35;
        }
        return totalCost;
    }    
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product productClass in _productClassList)
        {
            Console.WriteLine(productClass.GetPackingLabel());
        }

    }
    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_customerClass.GetCustomerInfo());

    }    public void DisplayOrderInfo()
    {
        Console.WriteLine();

        PackingLabel();

        Console.WriteLine();

        ShippingLabel();

        Console.WriteLine();

        Console.WriteLine($"Total price of the order: {GetOrderTotalCost()}");

        Console.WriteLine();
    }
}