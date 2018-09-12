using System;


namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please type hourly rate");
            int p1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type Hours worked per week");
            int p1Hours = Convert.ToInt32(Console.ReadLine());
            int p1Annual = p1Hourly * p1Hours * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Please type hourly rate");
            int p2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type Hours worked per week");
            int p2Hours = Convert.ToInt32(Console.ReadLine());
            int p2Annual = p2Hourly * p2Hours * 52;
            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(p1Hourly * p1Hours * 52);
            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(p2Hourly * p2Hours * 52);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool answer = p1Annual > p2Annual;
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}
