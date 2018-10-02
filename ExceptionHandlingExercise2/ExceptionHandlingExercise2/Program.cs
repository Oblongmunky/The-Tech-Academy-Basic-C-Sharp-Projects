using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your age.");
            var currentYear = 2018;
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                var yearBorn = currentYear - age;
                if (age <= 0)
                {
                    Console.WriteLine("0 or negative numbers will not work.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine(yearBorn);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input age in digits only, with no decimal.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
