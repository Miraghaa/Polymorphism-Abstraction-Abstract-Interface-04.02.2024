using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name, int employeeId, double basicSalary) : base(name, employeeId, basicSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BasicSalary / 2;
    }
}
