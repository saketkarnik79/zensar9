namespace CS_DemoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                //Logging code
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.HResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaned up everything...");
            }

            Console.ReadKey();
        }
    }
}
