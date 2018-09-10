using System;


namespace MathProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstNumber * 10000000);
            Console.WriteLine("Please type a second number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondNumber + 25);
            Console.WriteLine("Please enter a number with a decimal.");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(thirdNumber / 12.5);
            Console.WriteLine("Please type another number.");
            int fifty = 50;
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            bool answer = fourthNumber > fifty;
            Console.WriteLine(answer.ToString());
            Console.WriteLine("Please type one more number.");
            int fifthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fifthNumber % 7);
            Console.ReadLine();
        }
    }
}
