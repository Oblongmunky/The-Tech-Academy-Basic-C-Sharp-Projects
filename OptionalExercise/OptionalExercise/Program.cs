﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOptional a1 = new MyOptional();
            Console.WriteLine("Please enter a number");
            int uN1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Now you may choose to enter a second number but it is not required you can just hi enter");
            int uN2;
            bool b1 = int.TryParse(Console.ReadLine(), out uN2);
            if (b1)
            {
                Console.WriteLine(a1.Opt(uN1, b: uN2));
            }
            else
            {
                Console.WriteLine(a1.Opt(uN1));
            }
            Console.ReadLine();
        }
    }
}
