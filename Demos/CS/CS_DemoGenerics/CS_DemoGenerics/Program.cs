using CS_DemoGenerics.Collections;

namespace CS_DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(3);
            MyList<string> list2 = new MyList<string>(3);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list[2]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
