using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BankAccountB : IAccount
    {
        public Account Deposit(Account account, double amount)
    {
        double balance = account.InitialBalance + amount * 0.99;
        account.InitialBalance = balance;
        Console.WriteLine($"Balance B: {balance}");
        return account;
    }

    public void ShowBalance(Account account)
    {
        Console.WriteLine($"Balance B: {account.InitialBalance}");
    }

    public Account Withdraw(Account account, double amount)
    {
        double balance = account.InitialBalance - amount;
        account.InitialBalance = balance;
        Console.WriteLine($"Balance B: {balance}");
        return account;
    }
}
}
