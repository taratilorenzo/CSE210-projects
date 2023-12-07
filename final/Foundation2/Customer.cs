using System;
public class Customer
{
   //Attributes
   private string _name;
   private Address _address;
   private int _shippingFee;

   //Constructor
   public Customer(string name)
   {
    _name = name;
   }

   //Setters & Getters
   public string GetName()
   {
        return _name;
   }
   public string GetAddress()
   {
        return _address.FullAddress();
   }
   public void SetAddress(string street, string city, string state, string country)
   {
        _address = new Address(street, city, state, country);
   }
   public int GetShippingFee()
   {
    return _shippingFee;
   }

   //Methods
   public bool LiveInUSA()
   {
        if(_address.isUSA())
        {
            _shippingFee = 5;
            return true;
        }
        else
        {
            _shippingFee = 35;
            return false;
        }
   }
}