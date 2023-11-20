public class WritingAssignment : Assignment
{
    //Attributes
    private string _title;

    //Constructors
    public WritingAssignment()
    {

    }
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title= title;
    }

    //setters & getters

    //Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}