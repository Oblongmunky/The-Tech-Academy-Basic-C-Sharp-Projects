using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath a1 = new MyMath();
            Console.WriteLine("Please pick a number for me to do math with");
            int pick = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a1.AddTwoMinusOne(pick));
            Console.WriteLine("Please pick another number for me to do math with");
            int pick2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a1.TimesFourDivideTwice(pick2));
            Console.WriteLine("Please pick a third number for me to do math with");
            int pick3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a1.Square(pick3));
            Console.ReadLine();
        }
    }
}
