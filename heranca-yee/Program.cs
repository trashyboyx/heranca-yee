using heranca_yee.Entities;
using System;

namespace heranca_yee
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 500.0);
            Account account1 = new SavingsAccount(1002, "Anna", 500.0, 0.03);

            SavingsAccount savingsAccount = (SavingsAccount)account1;

            account.Withdraw(10.0);
            account1.Withdraw(10.0);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account1.Balance);
        }
    }
}
