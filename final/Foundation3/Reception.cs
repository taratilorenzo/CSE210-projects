public class Reception : Event
{
    //Attributes

    
    //Constructor
    public Reception(string type, string title, string description) : base(type, title, description)
    {
    }

    //Setters & Getters

    //Methods
    public string SendEmail()
    {
        return "RSVP";
    }
}