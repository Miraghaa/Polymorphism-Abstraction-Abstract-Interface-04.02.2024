using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Interface;
using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

public class CurrentAccount : Account, IAccount
{
    public CurrentAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public override void ShowAccountDetails()
    {
        Console.WriteLine($"Savings Account Number\r\n: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Balance increase: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Money go: {amount}");
        }
        else
        {
            Console.WriteLine("Money is little");
        }
    }

    public double CalculateInterest()
    {
        return Balance * 0.02;
    }
}
