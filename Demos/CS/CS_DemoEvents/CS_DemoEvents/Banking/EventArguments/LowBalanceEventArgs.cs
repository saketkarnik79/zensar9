using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DemoEvents.Banking.EventArguments
{
    public class LowBalanceEventArgs: EventArgs
    {
        public double AvailableBalance { get; private set; }

        public LowBalanceEventArgs(double balance)
        {
            this.AvailableBalance = balance;
        }
    }
}
