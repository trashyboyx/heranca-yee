using heranca_yee.Entities;
using System;

namespace heranca_yee
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500);
            SavingsAccount savingsAccount = new SavingsAccount(1003, "João", 0.0, 0.08);

            //UPCASTING
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1004, "Bob", 0.0, 200);
            Account account3 = new SavingsAccount(1005, "Ana", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount businessAccount1 = (BusinessAccount)account2;
            businessAccount1.Loan(100.0);

            if (account3 is BusinessAccount)
            {
                BusinessAccount businessAccount2 = (BusinessAccount)account3;
                businessAccount2.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (account3 is SavingsAccount)
            {
                SavingsAccount savingsAccount1 = (SavingsAccount)account3;
                savingsAccount1.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
