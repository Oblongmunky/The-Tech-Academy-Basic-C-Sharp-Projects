using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number assigned = new Number();
            assigned.Amount = 12.5m;
            Console.WriteLine(assigned.Amount);
            Console.ReadLine();
        }
    }
}
