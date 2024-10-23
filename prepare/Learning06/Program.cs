using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        

        Rectangle rectangle = new Rectangle(12, 2, "red");
        
        Circle circle = new Circle(2, "purple");
        



        List<Shape> shapes = 
        [
            square,
            rectangle,
            circle
        ];

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}