using System;
using System.Linq;

namespace JoinsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GroupJoin vs innerjoin
            //https://stackoverflow.com/questions/15595289/linq-to-entities-join-vs-groupjoin
            #region groupjoin
            var empbyDepts = Department.GetAllDepartments()
                                    .GroupJoin(Employee.AllEmployees(),
                                                d => d.DeptId,
                                                e => e.DepartmentId,
                                                (dept, emps) => new {
                                                    vdepart = dept,
                                                    vemp = emps
                                                });

            foreach (var obj in empbyDepts)
            {
                Console.WriteLine(obj.vdepart.DeptName);
                foreach (var item in obj.vemp)
                {
                    Console.WriteLine("\t" + item.Firstname + "\t" + item.Gender);
                }
            }
            #endregion
            //groupjoin produces a hierarchil result set and also non matching rows will be retrived
            //inner joinn produces a flat result and only matching rows will retrieved
            #region innerjoin
            var empjoin = Department.GetAllDepartments()
                 .Join(Employee.AllEmployees()
                 , d => d.DeptId
                 , e => e.DepartmentId
                 , (dept, emp) => new
                 {
                     vdept = dept,
                     vemp = emp
                 });
            foreach (var item in empjoin)
            {
                Console.WriteLine(item.vdept.DeptName + "\t" + item.vemp.Firstname);
            }

            #endregion

            //leftouterjoinn in sql  gives results=(common elements)+all elements from lefttable
            //in LINQ we use groupjoin with selectmany along with defaultifEmpty to behaves as leftouterjoin
            #region leftouterjoin
            var lefftouterjoin = Employee.AllEmployees()
                    .GroupJoin(Department.GetAllDepartments(),
                               e => e.DepartmentId,
                               d => d.DeptId,
                               (xemp, ydept) => new
                               {
                                   myemp = xemp,
                                   mydept = ydept
                               })
                     .SelectMany(z => z.mydept.DefaultIfEmpty(),
                                    (a, b) => new
                                    {
                                        ename = a.myemp,
                                        dname = b == null ? "Not applicable" : b.DeptName
                                    });
            foreach (var item in lefftouterjoin)
            {

                Console.WriteLine(item.dname + "\t" + item.ename);
            }
            #endregion



            #region CrossJoin

            //crossJoin gives cartiasen product of two tables

            var crossjoin = Employee.AllEmployees().SelectMany(d => Department.GetAllDepartments(),
                                                (e, d) => new
                                                {
                                                    e,
                                                    d
                                                });

            foreach (var item in crossjoin)
            {
                Console.WriteLine(item.d.DeptName + "\t" + item.e.Firstname);
            }

            #endregion

        }
    }
}
