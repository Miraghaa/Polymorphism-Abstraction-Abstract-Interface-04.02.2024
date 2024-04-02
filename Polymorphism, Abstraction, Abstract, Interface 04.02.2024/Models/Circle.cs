using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Radius * 2 * Math.PI;
    }
}
