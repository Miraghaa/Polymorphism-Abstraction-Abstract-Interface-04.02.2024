using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class Triangel : Shape
{
    public double Weight { get; set; }
    public double Height { get; set; }

    public Triangel(double weight, double height)
    {
        Weight = weight;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Weight * Height * 0.5;
    }
}
