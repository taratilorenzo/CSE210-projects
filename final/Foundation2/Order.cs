using System;

public class Order
{
    //Attributes
    private List<Product> _products;
    private Customer _customer;
    private int _cost;
    private string _packingLabel;
    private string _shippingLabel;

    //Constructors
    public Order()
    {
        _products = new List<Product>();
    }


    //Setters & Getters
    public string GetPackingLabel()
    {
        return _packingLabel;
    }
    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetName()} - Id: {product.GetProductId()} - Price: ${product.GetPrice()} (X{product.GetQuantity()}) - Total Cost={product.ProductCost()}");
        }
    }
    public string GetShippingLabel()
    {
        return _shippingLabel;
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.GetName()} - Address: {_customer.GetAddress()}");
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    //Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int TotalCost()
    {
        int sum = 0;
        int shippingCost;

        foreach(Product product in _products)
        {
            sum = sum + product.ProductCost();
        }
        
        if(_customer.LiveInUSA())
        {
            shippingCost = 5;
        }
        else shippingCost = 35;
        _cost = sum + shippingCost;
        return _cost;
    }

}