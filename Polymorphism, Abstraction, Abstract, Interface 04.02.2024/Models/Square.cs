using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class Square : Shape
{
    public double Teref {  get; set; }

    public Square(double teref)
    {
        Teref = teref;
    }
    public override double CalculateArea()
    {
        return Teref * Teref;
    }
}
