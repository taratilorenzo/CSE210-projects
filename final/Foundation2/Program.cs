using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Product product1 = new Product("Tooth Paste", "ID0012", 12, 4);
        Product product2 = new Product("IphoneXY", "ID0013", 2300, 2);
        Product product3 = new Product("PC 2013", "ID0014", 1246, 1);
        Product product4 = new Product("Torch", "ID0015", 20, 5);
        Product product5 = new Product("Jumper", "ID0016", 120, 1);
        Product product6 = new Product("Game Console", "ID0017", 2000, 1);
        Product product7 = new Product("Android Phone", "ID0018", 502, 3);
        Product product8 = new Product("Circular Saw", "ID0019", 1250, 1);
        //Console.WriteLine($"Cost of Product1: {product1.ProductCost()}$");

        Customer customer1 = new Customer("Lorenzo Tarati");
        customer1.SetAddress("Norval","Oakland","Idaho","USA");
        Customer customer2 = new Customer("Marcel Yope");
        customer2.SetAddress("Arue","Papeete","","Tahiti");
        Customer customer3 = new Customer("Chelsea Ti");
        customer3.SetAddress("Norglen","Aukland","","New Zealand");

        
        
        
        
        
        
        
        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product4);
        order1.SetCustomer(customer2);
        Console.WriteLine("ORDER1 - Shopping Cart:");
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Total Cost: {order1.TotalCost()}$ (incl. Shipping Fee={customer2.GetShippingFee()}$)");

        Order order2 = new Order();
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);
        Console.WriteLine("ORDER2 - Shopping Cart:");
        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"Total Cost: {order2.TotalCost()}$ (incl. Shipping Fee={customer1.GetShippingFee()}$)");




    }
}