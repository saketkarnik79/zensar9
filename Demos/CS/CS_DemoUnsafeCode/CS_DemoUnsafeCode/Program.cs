namespace CS_DemoUnsafeCode
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            unsafe
            {
                int a = 10;
                int* p = &a;
                Console.WriteLine($"Value of a: {a}");
                Console.WriteLine($"Address of a: {(int)p}");
                Console.WriteLine($"Value at address p: {*p}");
                *p = 20;
                Console.WriteLine($"New value of a: {a}");
            }

            unsafe
            {
                int[] arr = new int[5] { 1, 2, 3, 4, 5 };
                fixed (int* p = arr)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Value at arr[{i}]: " +
                            $"{*(p + i)}");
                    }
                }
            }

            unsafe
            {
                MyStruct myStruct = new MyStruct();
                myStruct.x = 10;
                myStruct.y = 20;
                MyStruct* p2 = &myStruct;
                Console.WriteLine($"Struct values: x = {p2->x}" +
                    $", y = {p2->y}");
            }
            Console.WriteLine("Press any key to exit the application...");

            Console.ReadKey();
        }
    }
}
