using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerationOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Range Repeat Empty
            #region Range

            //var MyInt=Enumerable.Range(1, 10).Where(x => x==x);
            //foreach (var item in MyInt)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Repeat
            //var result=Enumerable.Repeat("vishnu", 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Empty

            //IEnumerable<int> result = GetData();
            

            

            //if we want to return a empty list without trhowing error
            var result = Enumerable.Empty<int>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion

        }

        private static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}
