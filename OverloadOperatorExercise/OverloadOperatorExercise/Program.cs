using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.id = 2;
            employee2.id = 3;
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
