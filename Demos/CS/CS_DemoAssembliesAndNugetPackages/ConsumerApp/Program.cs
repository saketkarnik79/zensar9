using ProviderLib;

namespace ConsumerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc=new Calc();
            Console.WriteLine(calc.Add(20,10));
            Console.ReadKey();
        }
    }
}
