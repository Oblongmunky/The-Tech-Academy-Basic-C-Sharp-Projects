using System;

namespace BasicApprovalProgramForCarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());
            bool eligable = age > 15;
            bool risk = dui == "No";
            bool violations = tickets < 4;
            Console.WriteLine("Qualified?");
            Console.WriteLine(eligable && risk && violations);
            Console.ReadLine();
        }
    }
}
