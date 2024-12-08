public class Customer
{
    private string _customerName;
    private Address _customerAddressClass = new();

    public Customer()
    {
        _customerName = "";
    }
    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddressClass = address;
    }
    public Customer(string name, string street, string city, string state, string country)
    {
        _customerName = name;
        _customerAddressClass = new Address(street,city,state,country);
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string name)
    {
        _customerName = name;
    }

    public string GetCustomerAddress()
    {
        return _customerAddressClass.GetFullAddress();
    }
    public bool GetIfFromUSA()
    {
        return _customerAddressClass.GetIfUSA();
    }

    public string GetCustomerInfo()
    {
        return $"{_customerName} - Address: {_customerAddressClass.GetFullAddress()}";
    }
}