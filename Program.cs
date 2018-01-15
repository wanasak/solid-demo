using System;

namespace solid_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var empJohn = new Employee(1, "John", "Permanent");
            var empJason = new Employee(1, "Jason", "Temp");

            Console.WriteLine(string.Format("Employee {0} Bonus {1}", empJohn.ToString(), empJohn.CalculateBonus(10000).ToString()));
        }
    }
}
