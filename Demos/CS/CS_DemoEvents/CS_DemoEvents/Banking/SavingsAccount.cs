using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_DemoEvents.Banking.EventArguments;

namespace CS_DemoEvents.Banking
{
    public delegate void LowBalanceHandler(object sender, 
        //EventArgs e);
        LowBalanceEventArgs e);  

    public class SavingsAccount : AccountBase
    {
        public event LowBalanceHandler LowBalance;

        public override void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (this.Balance > 0 && this.Balance - amount >= 0)
            {
                this.Balance -= amount;
            }
            else
            {
                LowBalance?.Invoke(this,
                    //EventArgs.Empty);
                    new LowBalanceEventArgs(this.Balance));
            }
        }
    }
}
