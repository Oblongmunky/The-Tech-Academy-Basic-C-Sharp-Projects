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
            a1.outPut(out n1);
        }
    }
}
