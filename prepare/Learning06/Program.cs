using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 7);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Sky Blue", 10, 25);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Yellow", 3);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"Shape color: {color}");
            Console.WriteLine($"Shape area: {area}");
            Console.WriteLine("----------------------");
        }
    }
}