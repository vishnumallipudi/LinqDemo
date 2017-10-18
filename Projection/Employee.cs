using System.Collections.Generic;

namespace Projection
{
    class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double AnnSalary { get; set; }
        public string Gender { get; set; }
        public static IEnumerable<Employee> GetAllEmployees()
        {
            var emps = new List<Employee>() {
                new Employee() {Id=1,Firstname="Vishnu",LastName="Mallipudi",Email="vishnu@domain.com",AnnSalary=1000,Gender="Male" },
                new Employee() {Id=2,Firstname="Sudha",LastName="Mallipudi",Email="sudha@domain.com",AnnSalary=2000,Gender="Female" },
                new Employee() {Id=3,Firstname="Vasu",LastName="Mallipudi",Email="vasu@domain.com",AnnSalary=1500,Gender="Male" },
                new Employee() {Id=4,Firstname="Naveen",LastName="Tanakala",Email="naveen@domain.com",AnnSalary=4000,Gender="Male" },
                new Employee() {Id=5,Firstname="Sai",LastName="Vinnakota",Email="sai@domain.com",AnnSalary=3000,Gender="Male" },
                new Employee() {Id=6,Firstname="Ram",LastName="Paluri",Email="vishnu@domain.com",AnnSalary=6000,Gender="Female" },
                new Employee() {Id=7,Firstname="Venkat",LastName="Shreedhar",Email="venkat@domain.com",AnnSalary=4500,Gender="Male" },

            };
            return emps;
        }
    }
}
