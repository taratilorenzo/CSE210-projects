public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;

    //Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = true;
    }

    //Getters & Setters

    //Methods
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}