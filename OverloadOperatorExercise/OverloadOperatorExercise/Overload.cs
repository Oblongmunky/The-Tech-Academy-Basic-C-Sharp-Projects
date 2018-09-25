using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorExercise
{
    public class EmployeeIdNumber
    {
        public int n { get; set; }
        public EmployeeIdNumber()
        {
            n = 0;
        }
        public EmployeeIdNumber(int x)
        {
            n = x;
        }
        public static bool operator ==(EmployeeIdNumber x, EmployeeIdNumber y)
        {
            if (x == y)
                return true;
            else
                return false;
        }
        public static bool operator !=(EmployeeIdNumber x, EmployeeIdNumber y)
        {
            if (x != y)
                return true;
            else
                return false;
        }
    }
}
