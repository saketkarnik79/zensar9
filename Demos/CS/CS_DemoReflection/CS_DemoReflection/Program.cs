using System.Reflection;

namespace CS_DemoReflection
{
    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, {DisplayName()}");
        }

        private string DisplayName()
        {
            return $"Name: {Name}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() 
            { 
                Id = 1, Name = "James Bond" 
            };

            Type myType = typeof(MyClass);
            Console.WriteLine($"Class Name: {myType.Name}");
            Console.WriteLine($"Class Full Name: {myType.FullName}");

            PropertyInfo[] properties = 
                myType.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($" - {property.Name}, " +
                    $"{property.PropertyType.Name}");
            }
            MethodInfo[] methods = myType.GetMethods(
                    BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly
                );
            Console.WriteLine("Methods: ");
            foreach (var method in methods)
            {
                Console.WriteLine($" - {method.Name}");
                Console.WriteLine($"Invoking {method.Name}");

                if(method.Name.StartsWith("Display"))
                {
                    object result = method.Invoke(myClass, null);
                    if (result == null)
                    {
                        Console.WriteLine("No result...");
                    }
                    else
                    {
                        Console.WriteLine($"Result of {method.Name} " +
                            $"is {result.ToString()}");
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
