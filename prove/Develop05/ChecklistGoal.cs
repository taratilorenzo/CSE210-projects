public class ChecklistGoal : Goal
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonuses;

    //Constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonuses = bonus;
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
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}