using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyMath a1 = new MyMath();
            //Console.WriteLine(a1.addTwo(12));
            //Console.ReadLine();

            //MyMath a1 = new MyMath();
            //Console.WriteLine(a1.addTwo(12.9m));
            //Console.ReadLine();

            MyMath a1 = new MyMath();
            Console.WriteLine(a1.addTwo("12"));
            Console.ReadLine();
        }
    }
}
