using System.Globalization;
using System.Security.Principal;

namespace OOP_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new(Guid.NewGuid(), 1234);
            SavingsAccount savings = new(Guid.NewGuid(), checking.Pin);
        

            checking.Deposit(100, "Checking");
            savings.Deposit(200, "Savings");

            checking.CheckBalance("Checking");
            savings.CheckBalance("Savings");

            checking.CheckAccountNumber(1234);
            savings.CheckAccountNumber(1234);

            savings.CheckAccountNumber(0000);
        }
    }


    //Abstraction - mostly used when theres a generic class that other classes will inherit from and you do not want the user to be able to create an instance of the generic class
    // ** Can also be used to hide implementation of a particualr class to improve security, if necessary **
    //Abstract classes do not support multiple inheritance
    public abstract class BankAccount
    {

        public double Balance { get; set; }

        public int Pin { get; set; }

        public void Deposit(double amount, string accountType)
        {
            Balance += amount;
            Console.WriteLine($"{amount} has been successfully added to {accountType} Account");
        }

        public void CheckBalance(string accountType)
        {
            Console.WriteLine($"{accountType} Account is showing a general balance of: {Balance}");
        }

        public abstract void CheckAccountNumber(int providedPin);
    }

    public class CheckingAccount : BankAccount
    {
        private Guid CheckingAccountNumber { get; set; }

        public CheckingAccount(Guid guid, int pin)
        {
            CheckingAccountNumber = guid;
            Pin = pin;
        }

        //Abstract methods have to be implemented in the derived class
        //here we are overriding the abstract Deposit method. The Savings Account class does the same but slightly different, this is Polymorphi
        public override void CheckAccountNumber(int providedPin)
        {
            if (providedPin == Pin)
            {
                Console.WriteLine($"Checking Account Number: {CheckingAccountNumber}");
            }
            else
            {
                Console.WriteLine("Invalid Pin Entered");
            }
        }
    }

    public class SavingsAccount : BankAccount
    {
        private Guid SavingsAccountNumber { get; set; }

        public SavingsAccount(Guid guid, int pin)
        {
            SavingsAccountNumber = guid;
            Pin = pin;
        }

        public override void CheckAccountNumber(int providedPin)
        {
            if (providedPin == Pin)
            {
                Console.WriteLine($"Savings Account Number: {SavingsAccountNumber}");
            }
            else
            {
                Console.WriteLine("Invalid Pin Entered");
            }
        }
    }
}