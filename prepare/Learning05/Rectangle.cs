public class Rectangle : Shape
{
    //Attributes
    private double _width;
    private double _length;
    private string _name = "Rectangle";

    //Constructor

    //Setters & Getters
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }

    //Methods
    public override double GetArea()
    {
        return _length * _width;
    }
    public override string GetName()
    {
        return _name;
    }
}