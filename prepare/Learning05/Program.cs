using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine("");

        //Defining each shape
        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle("Purple", 5, 7);
        Circle circle = new Circle("Red", 4);
        Square square2 = new Square("Orange", 20);
        Rectangle rectangle2 = new Rectangle("Yellow", 25, 32);
        Circle circle2 = new Circle("Green", 27);

        //Defining the List
        List<Shape> shapes = new List<Shape>();

        //Adding shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square2);
        shapes.Add(rectangle2);
        shapes.Add(circle2);

        //Iterating through the list
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine("");
        }
    }
}