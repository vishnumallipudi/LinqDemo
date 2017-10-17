using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countries = new List<string>() { "india", "US", "China" };
            Console.WriteLine(countries.Min(c=>c.Length));
            Console.WriteLine($"Maximum value is: {nums.Max()}");
            Console.WriteLine($"Minimum value is: {nums.Min()}");
            Console.WriteLine($"Sum of all values is: {nums.Sum()}");
            //average() returns Double
            Console.WriteLine($"average of all values is: {nums.Average()}");
            Console.WriteLine($"Number of values is: {nums.Count()}");


            var appended = countries.Aggregate((a,b)=>a+", "+b);
            Console.WriteLine("Sum of all values using aggregate operator is "+nums.Aggregate((a, b) => a * b)  );
            Console.WriteLine("Sum of all values multiplied by 10  using aggregate operator is " + nums.Aggregate(10,(a, b) => a * b));

            Console.WriteLine(appended);


        }
    }
}
