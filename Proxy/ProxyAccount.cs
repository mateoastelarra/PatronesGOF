using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyAccount : IAccount
    {
        private IAccount bankAccount;

        public ProxyAccount(IAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        public Account Deposit(Account account, double amount)
        {
            if (bankAccount == null)
            {
                bankAccount = new BankAccount();
                return bankAccount.Deposit(account, amount);
            }
            return bankAccount.Deposit(account, amount);
            
                

        }

        public void ShowBalance(Account account)
        {
            if (bankAccount == null)
            {
                bankAccount = new BankAccount();
                bankAccount.ShowBalance(account);
            }
            else
            {
                bankAccount.ShowBalance(account);
            }
        }

        public Account Withdraw(Account account, double amount)
        {
            if (bankAccount == null)
            {
                bankAccount = new BankAccount();
                return bankAccount.Withdraw(account, amount);
            }
            return bankAccount.Withdraw(account, amount);
        }
    }
}
