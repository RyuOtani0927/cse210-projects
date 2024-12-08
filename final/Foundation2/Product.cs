public class Product
{
    private string _productName;
    private string _productID;
    private double _unitPrice;
    private int _productQuantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _unitPrice = price;
        _productQuantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string name)
    {
        _productName = name;
    }
    public string GetProductID()
    {
        return _productID;
    }    
    public void SetProductID(string id)
    {
        _productID = id;
    }
    public double GetUnitPrice()
    {
        return _unitPrice;
    }
    public void SetUnitPrice(double price)
    {
        _unitPrice = price;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void SetProductQuantity(int quantity)
    {
        _productQuantity = quantity;
    }

    public double GetProductTotalCost()
    {
        return _unitPrice * _productQuantity;
    }
    public string GetPackingLabel()
    {
        return $"{_productName} - {_productID}";
    }
}