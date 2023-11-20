public class Assignment
{
    //Attributes
    private string _studentName;
    private string _topic;

   //Constructor
    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }
    public Assignment(string name)
    {
        _studentName = name;
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //setters & getters
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    //methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}