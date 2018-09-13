using System;

namespace BooleanLoopExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick one: Left, Right, or Middle.");
            string answer = Console.ReadLine();
            bool isGuessed = answer == "Middle";

            do
            {
                switch (answer)
                {
                    case "Left":
                        Console.WriteLine("You picked Left. Try again");
                        Console.WriteLine("Pick one: Left, Right, or Middle.");
                        answer = Console.ReadLine();
                        break;
                    case "Right":
                        Console.WriteLine("You picked Right. Try again");
                        Console.WriteLine("Pick one: Left, Right, or Middle.");
                        answer = Console.ReadLine();
                        break;
                    case "Middle":
                        Console.WriteLine("Middle was the right choice!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Try again");
                        Console.WriteLine("Pick one: Left, Right, or Middle.");
                        answer = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
