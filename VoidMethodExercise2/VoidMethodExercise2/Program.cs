using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathVoidMethod a1 = new MyMathVoidMethod();
            a1.voidMath(12, 19);
            //a1.voidMath(a: 12, b: 6);
            Console.ReadLine();
        }
    }
}
