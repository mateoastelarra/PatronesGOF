using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IAccount
    {
        Account Withdraw(Account account, double amount);
        Account Deposit(Account account, double amount);
        void ShowBalance(Account account);
    }
}
