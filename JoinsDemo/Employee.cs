using System.Collections.Generic;

namespace JoinsDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string fname, int deptId, string gend)
        {
            this.Id = id;
            this.Firstname = fname;
            this.DepartmentId = deptId;
            Gender = gend;
        }

        public static List<Employee> AllEmployees()
        {
            return new List<Employee> {
                new Employee(1,"Vishnu",1,"Male"),
                new Employee(2,"Saibaba",2,"Female"),
                new Employee(3,"Naveen",3,"Female"),
                new Employee(4,"Venkat",1,"Female"),
                new Employee(5,"Raguveer",2,"Male"),
                new Employee(6,"Shreedhar",3,"Male"),
                new Employee(7,"Maneesh",2,"Female"),
                new Employee(8,"Mohan",3,"Male"),
                new Employee() {Id=9,Firstname="SpecialEmployee" }
            };

        }
    }
}
