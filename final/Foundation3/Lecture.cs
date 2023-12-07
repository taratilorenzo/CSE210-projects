public class Lecture : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;

    //Constructor
    public Lecture(string type, string title, string description, string speaker, int capacity) : base(type, title, description)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    //Setters & Getters

    //Methods
    public string FullDetails()
    {
        return $"{StandardDetails()} - {_speaker} - {_capacity}";
    }
}