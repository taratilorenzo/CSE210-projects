public class Square : Shape
{
    //Attributes
    private double _side;
    private string _name = "Square";

    //Constructor

    //Setters & Getters
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }

    //Methods
    public override double GetArea()
    {
        return _side * _side;
    }
    public override string GetName()
    {
        return _name;
    }
}