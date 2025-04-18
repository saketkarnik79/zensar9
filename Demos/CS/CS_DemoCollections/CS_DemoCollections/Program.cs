using System.Collections;

namespace CS_DemoCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            //StackDemo();

            //QueueDemo();

            //HashTableDemo();

            

            Console.ReadKey();
        }

        private static void GenericListDemo()
        {
            List<int> arr = new List<int>(3);
            List<int> arr2 = new List<int>();
            List<string> arr3 = new List<string>();
            List<DateTime> arr4 = new List<DateTime>();
            List<int> arr5 = new List<int>();
            Console.WriteLine($"Size: {arr.Capacity}" +
                $"Count: {arr.Count}");
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            //Console.WriteLine($"Size: {arr.Capacity}" +
            //    $"Count: {arr.Count}");
            //arr.Add(4.123d);
            //Console.WriteLine($"Size: {arr.Capacity}" +
            //    $"Count: {arr.Count}");
            //arr.Add("Five");
            //Console.WriteLine($"Size: {arr.Capacity}" +
            //    $"Count: {arr.Count}");

            Console.WriteLine($"Element at index 3: {arr[3]}");

            foreach (var item in arr)
            {
                Console.WriteLine($"{item}, ");
            }
        }

        private static void HashTableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add("Three", 3);
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }

        private static void QueueDemo()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4.123d);
            q.Enqueue("Five");
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }

        private static void StackDemo()
        {
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4.123d);
            stk.Push("Five");
            Console.WriteLine($"Peek: {stk.Peek()}");
            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
            }
        }

        private static void ArrayListDemo()
        {
            ArrayList arr = new ArrayList(3);
            Console.WriteLine($"Size: {arr.Capacity}" +
                $"Count: {arr.Count}");
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            Console.WriteLine($"Size: {arr.Capacity}" +
                $"Count: {arr.Count}");
            arr.Add(4.123d);
            Console.WriteLine($"Size: {arr.Capacity}" +
                $"Count: {arr.Count}");
            arr.Add("Five");
            Console.WriteLine($"Size: {arr.Capacity}" +
                $"Count: {arr.Count}");

            Console.WriteLine($"Element at index 3: {arr[3]}");

            foreach (var item in arr)
            {
                Console.WriteLine($"{item}, ");
            }
        }
    }
}
