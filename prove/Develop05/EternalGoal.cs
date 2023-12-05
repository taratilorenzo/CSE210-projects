public class EternalGoal : Goal
{
    //Attributes

    //Constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    //Getters & Setters

    //Methods
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}