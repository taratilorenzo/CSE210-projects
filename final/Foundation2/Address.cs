public class Address
{
     //Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Setters & Getters

    //Methods
    public bool isUSA()
    {
        if(_country.ToUpper() == "USA")
        {
            return true;
        }
        else return false;
    }

    public string FullAddress()
    {
        return $"{_street} street, {_city} \n {_state} - {_country}.";
    }
}