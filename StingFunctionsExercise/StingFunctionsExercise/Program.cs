using System;
using System.Text;

namespace StingFunctionsExercise
{
    class Program
    {
        static void Main()
        {
            string name = "Jeremy";
            string hi = "Hi,";
            StringBuilder sb = new StringBuilder("Hello!");
            sb.Append(" My purpose is to greet you.");
            sb.Append("\nI do this by typeing out a small paragraph to you.");
            sb.Append("\nThis will be done in only a few lines. ");
            sb.Append("\nIt was nice to meet you!");
            hi = hi.ToUpper();
            Console.WriteLine(hi + name + "\n" + sb);
            Console.ReadLine();
        }
    }
}
