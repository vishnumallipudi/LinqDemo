using System;
using System.Linq;

namespace Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Select
            var result = Employee.GetAllEmployees()
                                .Select(e=>new {
                                    Id =e.Id,
                                    Name =e.Firstname+" "+e.LastName,
                                    MonthySalary=e.AnnSalary/12});
            Console.WriteLine($"{"Id",-5} {"Name",-20}  {"MontlySalary",-10}");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id,-5} {item.Name,-20}  {String.Format("{0:C2}", item.MonthySalary),-10}");
            }


            #endregion

            #region SelectMany
            //var result2 = Student.GetAllStudents().SelectMany(e => e.Subjects);
            //Console.WriteLine("Total subjects are");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result2.Aggregate((a,b)=>a+", "+b));

            var r2= Student.GetAllStudents().SelectMany(s => s.Subjects, (student, subjects) => new { studName = student.Firstname, subjs = subjects });
            foreach (var item in r2)
            {
                Console.WriteLine(item.studName+"-"+item.subjs);
            }
            #endregion



        }
    }
}
