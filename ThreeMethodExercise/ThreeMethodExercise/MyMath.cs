using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodExercise
{
    public class MyMath
    {
        public int addTwo(int a)
        {
            return a + 2;
        }
        public decimal addTwo(decimal a)
        {
            return Convert.ToInt16(a + 3);
        }
        public string addTwo(string a)
        {
            a = "12";
            int i = 0;
            if (!Int32.TryParse(a, out i))
            {
                i = -1;
            }
            return a;
        }
    }
}
