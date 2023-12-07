public class Outdoor : Event
{
    //Attributes
    private string _weather;

    //Constructors
    public Outdoor(string type, string title, string description, string weather) : base(type, title, description)
    {
        _weather = weather;
    }

    //Setters & Getters

    //Methods
    public string WeatherForecast()
    {
        return "Sunny";
    }
}