using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Account
    {
        private int id;
        private string user;
        private double initialBalance;

        public Account(int id, string user, double initialBalance)
        {
            this.Id = id;
            this.user = user;
            this.initialBalance = initialBalance;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public double InitialBalance { get => initialBalance; set => initialBalance = value; }
    }
}
