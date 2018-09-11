using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string Page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string Answer = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. Am Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
