/* 
Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
*/
class Circle
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double Area()
    {
        return Math.PI * radius * radius;
    }
    public static Circle operator +(Circle c1, Circle c2)
    {
        double newRadius = Math.Sqrt(c1.Area() + c2.Area()) / Math.PI;
        return new Circle(newRadius);
    }
    public static Circle operator -(Circle c1, Circle c2)
    {
        double areaDifference = Math.Abs(c1.Area() - c2.Area());
        double newRadius = Math.Sqrt(areaDifference / Math.PI);
        return new Circle(newRadius);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        Circle c2 = new Circle(3);
        Circle sumCircle = c1 + c2;
        Circle diffCircle = c1 - c2;
        Console.WriteLine($"Area of Circle 1: {c1.Area()}");
        Console.WriteLine($"Area of Circle 2: {c2.Area()}");
        Console.WriteLine($"Sum of Areas: {sumCircle.Area()}");
        Console.WriteLine($"Difference of Areas: {diffCircle.Area()}");
    }
}
