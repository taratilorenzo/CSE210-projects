using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square();
        square.SetColor("Red");//SetColor() is from the Base class Shape
        square.SetSide(6);
        //Console.WriteLine($"The area of the {square.GetColor()} Square is: {square.GetArea()}");

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Yellow");
        rectangle.SetLength(5);
        rectangle.SetWidth(7);
        //Console.WriteLine($"The area of the {rectangle.GetColor()} Rectangle is: {rectangle.GetArea()}");

        Circle circle = new Circle();
        circle.SetColor("Blue");
        circle.SetRadius(3);
        //Console.WriteLine($"The area of the {circle.GetColor()} Circle is: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetName()} is: {shape.GetArea()}");
        }

    }
}