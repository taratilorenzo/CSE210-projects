using System;

public abstract class Goal
{
    //Attributes
    private string _shortName;
    private string _description;
    private int _points;
    //private string _type;
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    //Constructor
    /*public Goal()
    {

    }*/
    public Goal(){}
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Getters & Setters
    public string GetShortName() { return _shortName; }
    public void SetShortName(string shortname) { _shortName = shortname; }
    public string GetDescription() { return _description; }
    public void SetDescription(string description) { _description = description; }
    public int GetPoints() { return _points; }
    public void SetPoints(int points) { _points = points; }
    /*public string GetType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }*/


    //Methods
    public virtual string GetDetailsString()
    {
        return "";
    }
    
}