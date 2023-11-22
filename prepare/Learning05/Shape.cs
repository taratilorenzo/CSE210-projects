public class Shape
{
    //Attributes
    private string _color;

    //Constructor

    //Setters & Getters
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    //Methods
    public virtual double GetArea()
    {
        return -1;
    }

    public virtual string GetName()
    {
        return "";
    }
}