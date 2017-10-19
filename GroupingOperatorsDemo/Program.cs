using CastOperatorsDemo;
using System;
using System.Linq;
namespace GroupingOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //var empgroups = Employee.AllEmployees()
            //                    .GroupBy(e => new { e.Department, e.Gender })
            //                    .OrderBy(e => e.Key.Department)
            //                    .Select(a => new {
            //                        Dept = a.Key.Department,
            //                        Gender = a.Key.Gender,
            //                        Emp = a.OrderByDescending(x => x.Id)
            //                    });

            //foreach (var egroup in empgroups)
            //{
            //    Console.WriteLine(egroup.Dept + "\t" + egroup.Gender);
            //    foreach (var item in egroup.Emp)
            //    {
            //        Console.WriteLine($"\t\t{item.Id,-5} {item.Firstname,-10}{item.Gender,-8}{item.Department,-9}");
            //    }

            //}
            var emplist=Employee.AllEmployees()
                    .ToLookup(e => new { e.Department, e.Gender })
                    .OrderBy(e => e.Key.Department).ThenBy(e => e.Key.Gender);

            foreach (var group in emplist)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("\t\t"+item.Id+ "\t"+item.Gender);
                }
            }
            //ToLookUp is ImmediateExecution
            //GroupBy is DeferredExecution

        }
    }
}
