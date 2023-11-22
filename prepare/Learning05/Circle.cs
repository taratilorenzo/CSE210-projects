public class Circle : Shape
{
    //Attributes
    private double _radius;
    private string _name = "Circle";

    //Constructors

    //Setters & Getters
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    //Methods
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
    public override string GetName()
    {
        return _name;
    }
}