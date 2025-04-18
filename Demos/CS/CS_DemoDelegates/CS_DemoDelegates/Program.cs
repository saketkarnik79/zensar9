namespace CS_DemoDelegates
{
    public delegate void PrintMessage(string message);


    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintMessage printDelegate = 
            //    new PrintMessage(PrintToConsole);
            //PrintMessage printDelegate = PrintToConsole;

            //MULTICAST DELEGATE
            //printDelegate += new PrintMessage(PrintToUpperCase);

            //printDelegate?.Invoke("Hello, this is a delegate demo!");

            //ExecuteDelegate(printDelegate,
            //    "Delegates are powerful");

            //ExecuteDelegate(PrintToConsole, //Type inference
            //    "Delegates are powerful");

            //ExecuteDelegate(delegate(string message) //Anonymous methods
            //{
            //    Console.WriteLine(
            //        $"Anonymous method: {message.ToLower()}");
            //}, "Delegates are powerful");

            ExecuteDelegate((message) => //Anonymous methods with lambda expressions
            {
                Console.WriteLine(
                    $"Anonymous method with lambda expressions: " +
                    $"{message.ToLower()}");
            }, "Delegates are powerful");


            Console.ReadKey();
        }

        static void PrintToConsole(string message)
        {
            Console.WriteLine($"PrintToConsole: {message}");
        }

        static void PrintToUpperCase(string message)
        {
            Console.WriteLine($"PrintToUpperCase: " +
                $"{message.ToUpper()}");
        }

        static void ExecuteDelegate(PrintMessage printDelegate
            ,string message)
        {
            printDelegate?.Invoke(message);
        }
    }
}
