using CS_DemoEvents.Banking;
using CS_DemoEvents.Banking.EventArguments;

namespace CS_DemoEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount();
            account.LowBalance += Account_LowBalance;
            Console.WriteLine(account.Balance);
            account.Deposit(10000);
            Console.WriteLine(account.Balance);
            account.Withdraw(5500);
            Console.WriteLine(account.Balance);
            account.Withdraw(5000);
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }

        private static void Account_LowBalance(object sender, 
                //EventArgs e)
                LowBalanceEventArgs e)
        {
            Console.WriteLine($"Insufficient funds. Transaction declined.");
            Console.WriteLine($"Your current available balance: " +
                $"{e.AvailableBalance}");
        }
    }
}
