using System.Collections.Generic;

namespace SetOperatorsDemo
{
    class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if (x.Id==y.Id && x.Firstname==y.Firstname)
            {
                return true;
            }
            else if(x.Id==y.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Id.GetHashCode() ^ obj.Firstname.GetHashCode();
        }
    }
}
