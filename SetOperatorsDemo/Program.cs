using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperatorsDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string fname, string dept, string gend)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Department = dept;
            Gender = gend;
        }

        public static List<Employee> AllEmployees()
        {
            return new List<Employee> {
                new Employee(1,"Vishnu","IT","Male"),
                new Employee(2,"Saibaba","Finance","Female"),
                new Employee(3,"Naveen","Hardware","Female"),
                new Employee(4,"Venkat","IT","Female"),
                new Employee(5,"Raguveer","Finance","Male"),
                new Employee(6,"Shreedhar","Hardware","Male"),
                new Employee(7,"Maneesh","Finance","Female"),
                new Employee(8,"Mohan","Hardware","Male"),
                new Employee(8,"Mohan","Hardware","Male")
            };

        }
        //public override bool Equals(object obj)
        //{
        //    var emp = (Employee)obj;
        //    if (this.Id == emp.Id && this.Firstname == emp.Firstname)
        //    {
        //        return true;
        //    }
        //    else if (this.Id == emp.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public override int GetHashCode()
        //{
        //    return this.Id.GetHashCode() ^ this.Firstname.GetHashCode();
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {


            #region Distinct

            //var slist = new List<string> { "vishnu","VISHNU","US","us","UK","uk"};
            //ignores the case
            //var dlist = slist.Distinct();
            //dlist.print();

            //consider the case
            //var ilist = slist.Distinct(StringComparer.OrdinalIgnoreCase);
            //ilist.print();

            //var newemps=Employee.AllEmployees().Distinct(new EmployeeComparer());
            //newemps.printEmployees();


            //or you can override those methods in employee class itself

            //var newemps = Employee.AllEmployees().Distinct();
            //newemps.printEmployees();


            //or simply project to new anonymous object
            //var newemps = Employee.AllEmployees().Select(x => new { x.Id, x.Firstname }).Distinct();
            //foreach (var item in newemps)
            //{
            //    Console.WriteLine($"{item.Id,-3} {item.Firstname,-13} {item.GetHashCode(),-13}");
            //}


            #endregion

            #region Union
            //removes duplicates and also gives elements that are atleast in one set
            // int[] a = { 1,1,1,1,1 };
            // int[] b = { 1,1,1};
            //var some= a.Union(b);
            // foreach (var item in some)
            // {
            //     Console.WriteLine(item);
            // }

            //List<Employee> a = new List<Employee> {
            //    new Employee() { Id=101,Firstname="Mike"},
            //    new Employee() { Id=102,Firstname="Mohan"},
            //    new Employee() { Id=103,Firstname="Maneesh"}
            //};
            //List<Employee> b = new List<Employee> {
            //    new Employee() { Id=101,Firstname="Mike"},
            //    new Employee() { Id=102,Firstname="vishnu"},
            //    new Employee() { Id=104,Firstname="Maneesh"}
            //};
            //var uniemp = a.Select(x => new { x.Id, x.Firstname })
            //                .Union(b.Select(x => new { x.Id, x.Firstname }));
            //foreach (var item in uniemp)
            //{
            //    Console.WriteLine($"{item.Id,-3} {item.Firstname,-13} {item.GetHashCode(),-13}");
            //}


            #endregion
            #region intersect
            //gives the commmon element and also removes the duplicates

            //int[] a = { 1, 1, 1, 1, 1 };
            //int[] b = { 1, 1, 1 };
            //var some = a.Intersect(b);
            //output: 1


            //int[] a = { 1, 2,3,4,5 };
            //int[] b = { 1, 3,6,7,8,9,3};
            //var some = a.Intersect(b);
            //output:1,3
            //var exp= b.Select(x=>x.ToString()).Aggregate((x, y) => x.ToString() + ", " + y.ToString());

            //foreach (var item in some)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Except
            //int[] a = { 1, 1, 1, 1, 1 };
            //int[] b = { 1, 1, 1 };
            //var some = a.Except(b);
            //output: 1


            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 3, 6, 7, 8, 9, 3 };
            var some = a.Except(b);
            //output:1,3
            //var exp= b.Select(x=>x.ToString()).Aggregate((x, y) => x.ToString() + ", " + y.ToString());

            foreach (var item in some)
            {
                Console.WriteLine(item);
            }



            #endregion
        }

    }
    public static class mylinq
    {
        public static void print(this IEnumerable<string> s)
        {
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        public static void printEmployees(this IEnumerable<Employee> s)
        {
            foreach (var item in s)
            {
                Console.WriteLine($"{item.Id,-3} {item.Firstname,-13} {item.GetHashCode(),-13}");
            }
        }

    }
}
