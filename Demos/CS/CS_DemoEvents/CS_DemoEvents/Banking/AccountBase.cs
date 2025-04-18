using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DemoEvents.Banking
{
    public abstract class AccountBase
    {
        public double Balance { get; protected set; }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
    }
}
