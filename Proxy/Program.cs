using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Bill Gates", 10000000000);

            IAccount proxyAccount = new ProxyAccount(new BankAccount());

            proxyAccount.ShowBalance(account);

            proxyAccount.Withdraw(account, 1000000);
            proxyAccount.Deposit(account, 1000);

            proxyAccount.ShowBalance(account);

            Console.WriteLine("++++++++++++++++++++++++++++++++");

            proxyAccount = new ProxyAccount(new BankAccountB());

            proxyAccount.ShowBalance(account);

            proxyAccount.Withdraw(account, 1000000);
            proxyAccount.Deposit(account, 1000);

            proxyAccount.ShowBalance(account);
        }
    }
}
