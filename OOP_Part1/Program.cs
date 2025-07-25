using System.Globalization;
using System.Runtime.CompilerServices;

namespace OOP_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new(Guid.NewGuid(), 1234);
            account.CheckBalance();

            account.CheckAccountNumber(1234);
            account.CheckAccountNumber(0000);
        }
    }

    //Encapsulation
    public class BankAccount
    {
        public double Balance { get; set; } = 0.0;

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Bank Account is showing a general balance of: {Balance}");
        }
    }

    //Inheritance
    public class CheckingAccount : BankAccount
    {
        private Guid AccountNumber { get; set; }
        private int Pin { get; set; }

        public CheckingAccount(Guid guid, int Pin)
        {
            AccountNumber = guid;
            this.Pin = Pin; //need the "this" keyword if the local variable being passed to class has the exact same name as the field/property
        }
        public void CheckAccountNumber(int providedPin)
        {
            if (providedPin == Pin)
            {
                Console.WriteLine($"Account Number: {AccountNumber}");
            }
            else
            {
                Console.WriteLine("Invalid Pin Entered");
            }
        }
    }
}