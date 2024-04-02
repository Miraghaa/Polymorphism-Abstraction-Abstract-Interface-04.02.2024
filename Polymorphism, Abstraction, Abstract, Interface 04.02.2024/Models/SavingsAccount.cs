using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Interface;
using Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models.BaseModel;

namespace Polymorphism__Abstraction__Abstract__Interface_04._02._2024.Models;

internal class SavingsAccount : Account, IAccount
{
    public SavingsAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public double CalculateInterest()
    {
        return Balance * 15;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Balance increase {Balance}");
    }

    public override void ShowAccountDetails()
    {
        Console.WriteLine($"Savings Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if(Balance < amount)
        {
            Console.WriteLine("Money is little");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Succsefully");
        }
    }
}
