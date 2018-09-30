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
            Console.WriteLine("Please enter a number.");
            string number = string.Format(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\users\grund\logs\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.WriteLine(@"C:\users\grund\logs\log.txt");
            Console.ReadLine();
        }
    }
}
