using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace CastOperatorsDemo
{
    class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Department { get; set; }
        public Employee()
        {

        }
        public Employee(int id,string fname,string dept)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Department = dept;
        }

        public static List<Employee> AllEmployees()
        {
            return  new List<Employee> {
                new Employee(1,"Vishnu","IT"),
                new Employee(2,"Saibaba","Finance"),
                new Employee(3,"Naveen","Hardware"),
                new Employee(4,"Venkat","IT"),
                new Employee(5,"Raguveer","Finance"),
                new Employee(6,"Shreedhar","Hardware"),
                new Employee(7,"Maneesh","Finance"),
                new Employee(8,"Mohan","Hardware"),
            };

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ToList, ToArray, Todicitionary ,Tolookup
            //var mylist= Student.GetAllStudents().ToList();
            //var mylist = Student.GetAllStudents().ToArray();
            //foreach (var item in mylist)
            //{
            //    Console.WriteLine(item.Firstname);
            //}

            //var mylist = Student.GetAllStudents().ToDictionary(s => s.Id);


            //Console.WriteLine($"{"kvp.Key"} {"kvp.Value.Id",-5}{"kvp.Value.Firstname",-8}{"kvp.Value.Email",2}");
            //foreach (KeyValuePair<int,Student> kvp in mylist)
            //{
            //    Console.WriteLine($"{kvp.Key} {kvp.Value.Id,10}{kvp.Value.Firstname,-10}{kvp.Value.Email,10}");
            //}

            //var emplist = Employee.AllEmployees().ToLookup(e=>e.Department);

            //foreach (var item in emplist)
            //{
            //    Console.WriteLine(item.Key+" ");
            //    foreach (var subitem in emplist[item.Key])
            //    {
            //        Console.WriteLine("\t"+subitem.Firstname);
            //    }
            //}



            ArrayList al = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                al.Add(i);
            }
            al.Add("Vishnu");
            //arraylist works on object type

            //Cast: Converts all items in list to specified type.
            //If failed to cast, Invalid Cast Expcetion Thrown
            //al.Cast<int>();

            //OfType: gets only specified type list

            foreach (var item in al.OfType<int>())
            {
                Console.WriteLine(item);
            }

        }
    }
}
