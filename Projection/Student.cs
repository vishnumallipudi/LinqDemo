using System.Collections.Generic;

namespace Projection
{
    class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Subjects { get; set; }
        public string Gender { get; set; }
        public static IEnumerable<Student> GetAllStudents()
        {
            var emps = new List<Student>() {
                new Student() {Id=1,Firstname="Vishnu",LastName="Mallipudi",Email="vishnu@domain.com",Subjects=new List<string> {"C#","ASP.NET" },Gender="Male" },
                new Student() {Id=2,Firstname="Sudha",LastName="Mallipudi",Email="sudha@domain.com",Subjects=new List<string> { "C#","ASP.NET MVC"},Gender="Female" },
                new Student() {Id=3,Firstname="Vasu",LastName="Mallipudi",Email="vasu@domain.com",Subjects=new List<string> { "ADO.NET"},Gender="Male" },
                new Student() {Id=4,Firstname="Naveen",LastName="Tanakala",Email="naveen@domain.com",Subjects=new List<string> { "LINQ","C#"},Gender="Male" },
                new Student() {Id=5,Firstname="Sai",LastName="Vinnakota",Email="sai@domain.com",Subjects=new List<string> { "SQL","Entity Framework"},Gender="Male" },
                new Student() {Id=5,Firstname="Ram",LastName="Paluri",Email="vishnu@domain.com",Subjects=new List<string> { "HTML","CSS","Javascript"},Gender="Female" },
                new Student() {Id=6,Firstname="Venkat",LastName="Shreedhar",Email="venkat@domain.com",Subjects=new List<string> { "Jquery"},Gender="Male" },

            };
            return emps;
        }
    }
}
