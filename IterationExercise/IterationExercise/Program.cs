using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercise
{
    class Program
    {
        static void Main()
        {   //1.
            //string[] numbersAlpha = { "one", "two", "three", "four", "five" };
            //Console.WriteLine("Please enter your name.");
            //string name = Console.ReadLine();


            //foreach (string nA in numbersAlpha)
            //{
            //    Console.WriteLine(nA + name); 
            //}
            //Console.ReadLine();

            ////2. and 3.
            //string[] numbersAlpha = { "one", "two", "three", "four", "five" };
            //Console.WriteLine("Please enter your name.");
            //string name = Console.ReadLine();

            //for (; ; )
            //{
            //    Console.WriteLine(numbersAlpha[0] + name);
            //    Console.WriteLine(numbersAlpha[1] + name);
            //    Console.WriteLine(numbersAlpha[2] + name);
            //    Console.WriteLine(numbersAlpha[3] + name);
            //    Console.WriteLine(numbersAlpha[4] + name);
            //    break;
            //}


            //4.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++);

            //5.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i <= numbers.Length; i++);

            //6. 7. 8.
            //List<string> names = new List<string> { "Jeremy Grundy", "Andrea Brewer", "Harper Brewer Grundy" };
            //Console.WriteLine("Please type in Jeremy, Andrea or Harper to search the list.");
            //string answer = Console.ReadLine();

            //if (answer == "Jeremy")
            //{
            //    Console.WriteLine(names.IndexOf("Jeremy Grundy"));
            //}
            //else if (answer == "Andrea")
            //{
            //    Console.WriteLine(names.IndexOf("Andrea Brewer"));
            //}
            //else if (answer == "Harper")
            //{
            //    Console.WriteLine(names.IndexOf("Harper Brewer Grundy"));
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid input");
            //}
            //Console.ReadLine();


            //9. 10.
            //List<string> names = new List<string> { "Jeremy Grundy", "Andrea Brewer", "Harper Brewer Grundy", "Jeremy Grundy" };
            //Console.WriteLine("Please type in Jeremy, Andrea or Harper to search the list for index number.");
            //string answer = Console.ReadLine();


            //if (answer == "Jeremy")
            //{
            //    Console.WriteLine(0);
            //}
            //else if (answer == "Andrea")
            //{
            //    Console.WriteLine(1);
            //}
            //else if (answer == "Harper")
            //{
            //    Console.WriteLine(2);
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid input");
            //}
            //Console.ReadLine();

            //11.
            List<string> names = new List<string> { "Jeremy Grundy", "Andrea Brewer", "Harper Brewer Grundy", "Jeremy Grundy" };
            List<string> count = new List<string>();

            
            foreach (string name in names)
            {
                if (count.Contains(name))
                {
                    Console.WriteLine(name);
                }

                else
                {
                    count.Add(name);
                    Console.WriteLine(name + " has not appeared");
                    
                }
            }
            Console.ReadLine();
        }
    }
}
