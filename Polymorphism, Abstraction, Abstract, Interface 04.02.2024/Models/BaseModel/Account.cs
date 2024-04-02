namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

public abstract class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public abstract void ShowAccountDetails();
}
