using System;


namespace ShippingQuoteforPackageExersise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int pWeight = Convert.ToInt16(Console.ReadLine());
            string resultWeight = pWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Please enter package width:";
            Console.WriteLine(resultWeight);
            int pWidth = Convert.ToInt16(Console.ReadLine());
            if (pWeight > 50.0)
            {
                return;
            }
            Console.WriteLine("Please enter the package height:");
            int pHeight = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int pLength = Convert.ToInt16(Console.ReadLine());
            int dimensions = pWidth + pHeight + pLength;
            string resultDimensions = dimensions > 50 ? "Package too big to be shipped via Package Express. Have a good day." : "Please wait while we calculate your results.";
            Console.WriteLine(resultDimensions);
            int quote = dimensions * pWeight / 100;
            if (dimensions > 50.0)
            {
                return;
            }
            Console.WriteLine("Your estimated total for shipping this package is :");
            Console.WriteLine("$" + quote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
} 