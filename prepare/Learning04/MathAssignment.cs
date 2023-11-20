public class MathAssignment : Assignment
{
    //Attributes
    private string _textBookSection;
    private string _problems;

    //Constructors
    public MathAssignment() : base()
    {

    }
    public MathAssignment(string name, string topic, string textBookSection, string problem) : base(name, topic)
    {
        _problems = problem;
        _textBookSection = textBookSection;

    }

    //Methods
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}