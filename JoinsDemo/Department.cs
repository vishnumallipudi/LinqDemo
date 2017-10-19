using System.Collections.Generic;

namespace JoinsDemo
{
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public Department()
        {

        }
        public Department(int id,string name)
        {
            DeptId = id;
            DeptName = name;
        }

        public static IEnumerable<Department> GetAllDepartments()
        {
            return new List<Department> {
                new Department(1,"IT"),
                new Department(2, "Finance"),
                new Department(3, "Hardware")
            };
        }
    }
}
