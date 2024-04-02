namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

public abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public double BasicSalary { get; set; }

    public Employee(string name, int employeeId, double basicSalary)
    {
        Name = name;
        EmployeeId = employeeId;
        BasicSalary = basicSalary;
    }
    public abstract double CalculateSalary();
}
