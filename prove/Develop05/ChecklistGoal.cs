public class ChecklistGoal : Goal
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonuses;

    //Constructors
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonuses = bonus;
    }

    //Getters & Setters
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetBonuses()
    {
        return _bonuses;
    }
    public void SetBonuses(int bonuses)
    {
        _bonuses = bonuses;
    }

    //Methods
    public override int RecordEvent()
    {
        _amountCompleted++;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        
        if(_target != _amountCompleted )
        {
            return false;
        }
        else
        {
            SetPoints(GetPoints()+_bonuses);
            return true;
        }
    }
    public override string GetDetailsString()
    {
        if(IsComplete())
        {
            return $"[X] {GetShortName()} ({GetDescription()}) - Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) - Currently completed {_amountCompleted}/{_target}";;
        } 
    }
    public override string GetStringRepresentation()
    {
         return $"ChecklistGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonuses}|{_target}|{_amountCompleted}";
    }
}