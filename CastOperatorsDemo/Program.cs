using System.Collections.Generic;
namespace CastOperatorsDemo
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
        public Employee(int id,string fname,string dept,string gend)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Department = dept;
            Gender = gend;
        }

        public static List<Employee> AllEmployees()
        {
            return  new List<Employee> {
                new Employee(1,"Vishnu","IT","Male"),
                new Employee(2,"Saibaba","Finance","Female"),
                new Employee(3,"Naveen","Hardware","Female"),
                new Employee(4,"Venkat","IT","Female"),
                new Employee(5,"Raguveer","Finance","Male"),
                new Employee(6,"Shreedhar","Hardware","Male"),
                new Employee(7,"Maneesh","Finance","Female"),
                new Employee(8,"Mohan","Hardware","Male"),
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



            //ArrayList al = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    al.Add(i);
            //}
            //al.Add("Vishnu");
            //arraylist works on object type

            //Cast: Converts all items in list to specified type.
            //If failed to cast, Invalid Cast Expcetion Thrown
            //al.Cast<int>();

            //OfType: gets only specified type list(filteringOperators)

            //foreach (var item in al.OfType<int>())
            //{
            //    Console.WriteLine(item);
            //}

            
        }
    }
}
