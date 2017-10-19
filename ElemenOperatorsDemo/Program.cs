using System;
using System.Linq;

namespace ElemenOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1,2,3,4,5,6,7,8,9};
            int[] b = { };
            int[] c = { 2 };

            Console.WriteLine("First: "+a.First());
            Console.WriteLine("First lambda: " + a.First(x=>x%4==0));
            Console.WriteLine("First or default: " + b.FirstOrDefault());
            //similarly last, lastOrDefault
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Element at 2: " + a.ElementAt(2));
            Console.WriteLine("Element at 15 or defult: " + a.ElementAtOrDefault(15));

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Single: " + c.Single());
            Console.WriteLine("Single lambda: " + c.Single(x=>x%2==0));
            Console.WriteLine("Single: " + b.SingleOrDefault());


            Console.WriteLine(); Console.WriteLine();
            foreach (var item in c.DefaultIfEmpty())
            {
                Console.WriteLine(item);
            }
            foreach (var item in b.DefaultIfEmpty(100))
            {
                Console.WriteLine(item);
            }
           















        }
    }
}
