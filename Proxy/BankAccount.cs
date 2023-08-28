using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BankAccount : IAccount
    {
        public Account Deposit(Account account, double amount)
        {
            double balance = account.InitialBalance + amount;
            account.InitialBalance = balance;
            Console.WriteLine($"Balance: {balance}");
            return account;
        }

        public void ShowBalance(Account account)
        {
            Console.WriteLine($"Balance: {account.InitialBalance}");
        }

        public Account Withdraw(Account account, double amount)
        {
            double balance = account.InitialBalance - amount;
            account.InitialBalance = balance;
            Console.WriteLine($"Balance: {balance}");
            return account;
        }
    }
}
