public abstract class Shape
{
    public string Name { get; set; }
    public Shape(string name) { Name = name; }
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(string name, double width, double height)
        : base(name) { Width = width; Height = height; }

    public override double GetArea() { return Width * Height; }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(string name, double radius)
        : base(name) { Radius = radius; }
    public override double GetArea() { return Math.PI * Radius * Radius; }
}

// Bài này sai vì Main nằm bên ngoài class
//class Program
//{
//static void Main()
//    {
//        List<Shape> shapes = new List<Shape>
//        {
//            new Rectangle("Hình chữ nhật", 5, 10),
//            new Circle("Hình tròn", 4)
//        };

//        foreach (Shape shape in shapes)
//        {
//            Console.WriteLine($"{shape.Name} - Diện tích: {shape.GetArea():0.00}");
//        }
//    }
//}
