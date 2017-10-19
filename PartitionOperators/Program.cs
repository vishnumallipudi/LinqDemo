using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take TakeWhile,
            //Skip,SkipWhile

            List<string> Countries = new List<string> {  "India","China", "Britain","Nepal","Japan",
                                                        "UK","Mexico","US","Phillipines","Korea",
                                                     "Brazil","Chile","Rio","Vietnam","Russia",};
            //IEnumerable<string> mylist = Countries.Take(3);


            //var mylist = Countries.Skip(4);

            //var mylist = Countries.TakeWhile(delegate (string s) { return s.Length > 2; });

            //var mylist = Countries.SkipWhile(delegate (string s) { return s.Length > 2; });


            do
            {
                int pn = 0;
                int ps = 3;
                Console.WriteLine("Enter Pagenumber 1-5:");
                if (int.TryParse(Console.ReadLine(), out pn))
                {
                    if (pn >= 1 && pn <= 5)
                    {
                        var mylist = Countries.Skip((pn - 1) * ps).Take(ps);
                        foreach (var item in mylist)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Page number must be between 1 and 5");
                    }

                }
                else
                {
                    Console.WriteLine("Page number must be between 1 and 5");
                }
            } while (true);






            
        }
    }
}
