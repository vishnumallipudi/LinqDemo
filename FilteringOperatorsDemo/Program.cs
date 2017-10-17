using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //where and OfType

            var mylist = new ArrayList(5);
            mylist.Add("vishnu");
            mylist.Add("siababa");
            mylist.Add(5);
            mylist.Add("naveen");
            mylist.Add("shreedhar");

            var stringlist = mylist.OfType<string>();
            Console.WriteLine("Only strings are");
            foreach (var item in stringlist)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            var index = stringlist.Max(a => a.Length);
            var longlist = stringlist.Where(s => s.Length == index);
            foreach (var item in longlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Without  foreach");
            var x = longlist.GetEnumerator();
            while (x.MoveNext())
            {
                Console.WriteLine(x.Current);
                
            }
            
        }
    }
}
