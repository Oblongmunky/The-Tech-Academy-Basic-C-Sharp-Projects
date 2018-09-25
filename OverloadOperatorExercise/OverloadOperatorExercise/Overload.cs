using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorExercise
{
    public class Number: Employee
    {
        int n;
        public Number()
        {
            n = 0;
        }
        public Number(int x)
        {
            n = x;
        }
        public static bool operator ==(Number x, Number y)
        {
            if (x.n == y.n)
                return true;
            else
                return false;
        }
        public static bool operator !=(Number x, Number y)
        {
            if (x.n != y.n)
                return true;
            else
                return false;
        }
        public int getValue()
        {
            return n;
        }
    }
}
