public class Event
{
    //Attributes
    private string _title;
    private string _type;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    private string title;
    private string description;

    //Constructor
    public Event(string type, string title, string description)
    {
        _dateTime = DateTime.Now;
        _address = new Address("Woodglen","Auckland","GlenEden","NZ");
        _title = title;
        _description = description;
        _type = type;
    }

    //Setters & Getters

    //Methods
    public string StandardDetails()
    {
        return $"{_title} - {_description} - {_dateTime} - {_address.FullAddress()}";
    }

    public string ShortDescription()
    {
        return $"{_type} - {_title} - {_dateTime}";
    }
}