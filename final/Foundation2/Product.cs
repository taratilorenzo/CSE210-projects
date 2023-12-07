public class Product
{
    //Attributes
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    //Constructor
    public Product( string name, string productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Setters & Getters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void GetProductId(string id)
    {
        _productId = id;
    }
    public int GetPrice()
    {
        return _price;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    //Methods
    public int ProductCost()
    {
        return _quantity * _price;
    }


}