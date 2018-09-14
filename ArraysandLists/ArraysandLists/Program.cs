using System;
using System.Collections.Generic;

namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] alphaArray = { "One", "Two", "Three", "Four", "Five" };
            List<string> alphaList = new List<string>();
            alphaList.Add("One");
            alphaList.Add("Two");
            alphaList.Add("Three");
            alphaList.Add("Four");
            alphaList.Add("Five");
            Console.WriteLine("Please select a index from the number array between 0 and 9.");
            int nA = Convert.ToInt16(Console.ReadLine());
            if (nA < 11)//How can I have Console.ReadLine select an index and print it?//
            {
                Console.WriteLine("That index is the " + numArray[nA]);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
            Console.WriteLine("Please select a index from the alpha array between 0 and 4.");
            int aA = Convert.ToInt16(Console.ReadLine());
            if (aA < 5)//How can I have Console.ReadLine select an index and print it?//
            {
                Console.WriteLine("That index is the " + alphaArray[aA]);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
            Console.WriteLine("Please select a index from the alpha list between 0 and 4.");
            int aL = Convert.ToInt16(Console.ReadLine());
            if (aL < 5)
            {
                Console.WriteLine("That is the " + alphaList[aL]);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
            Console.ReadLine();
        }
    }
}
