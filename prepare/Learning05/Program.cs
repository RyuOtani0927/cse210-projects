using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new();

        shapes.Add(new Square("red",5));
        shapes.Add(new Rectangle("yellow",2,10));
        shapes.Add(new Circle("blue",3));

        Console.WriteLine();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}