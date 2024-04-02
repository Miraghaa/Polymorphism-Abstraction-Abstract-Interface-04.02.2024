using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Interface;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class DVD : ILibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int AvailableCopies { get; set; }

    public void CheckOut(int count)
    {
        Console.WriteLine($"AvailableCopies: {AvailableCopies -= count}");
    }

    public void Return(int count)
    {
        Console.WriteLine($"AvailableCopies: {AvailableCopies += count}");
    }
}
