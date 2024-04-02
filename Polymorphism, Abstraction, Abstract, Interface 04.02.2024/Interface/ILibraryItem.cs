namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Interface;

public interface ILibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int AvailableCopies { get; set; }
    public void CheckOut(int count);
    public void Return(int count);
}
