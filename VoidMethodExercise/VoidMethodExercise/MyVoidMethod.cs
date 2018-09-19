using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodExercise
{
    public class MyVoidMethod
    {
        public void addTwo(int num1, int num2)
        {
            num1 = Convert.ToInt16(Console.ReadLine()) + 1;
            Console.WriteLine(num2);
        }
    }
}
