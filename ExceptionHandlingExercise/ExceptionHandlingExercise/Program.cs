using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Pick a number to divide each number in the list by");
            int numberOne = Convert.ToInt16(Console.ReadLine());
                foreach (int number in numbers)
                {
                    Console.WriteLine(number / numberOne);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
