using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVoidMethod run = new MyVoidMethod();
            Console.WriteLine("type a number");
            int pick1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("type another number");
            int pick2 = 4;
            run.addTwo(num1: pick1, num2: pick2);

            Console.ReadLine();
        }
        
    }
}
