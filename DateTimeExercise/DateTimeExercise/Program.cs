using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The current Date\\Time is " + date);
            Console.WriteLine("Please enter a number.");
            double number = Convert.ToDouble(Console.ReadLine());
            DateTime futureTime = date.AddHours(number);
            Console.WriteLine(futureTime + " is what it will be in " + number + " hours.");
            Console.ReadLine();
        }
    }
}