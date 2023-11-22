public class EternalGoal : Goal
{
    //Attributes

    //Constructors
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
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