using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarLinkExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greeting = "Hello There Partner!";
            Console.WriteLine(greeting + " Please type first name.");
            var fName = Console.ReadLine();
            Console.WriteLine("Now please enter your last name.");
            string lName = Console.ReadLine();
            Chains getName = new Chains(fName, lName);
            Console.WriteLine(value: getName.fName + getName.lName);
            Console.ReadLine();
        }
    }
}
