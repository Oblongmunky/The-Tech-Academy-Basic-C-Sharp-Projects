using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOut a1 = new MyOut();
            Console.WriteLine("type a number");
            int n1 = Convert.ToInt16(Console.ReadLine());
            // I make n2 a place to store the empty var to be used later
            int n2;
            // n2 becomes my a / b = a
            a1.outPut(out n2, n1);
            Console.WriteLine(n2);
            Console.ReadLine();
        }
    }
}
