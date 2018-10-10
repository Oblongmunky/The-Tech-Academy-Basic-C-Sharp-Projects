using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username: ");
            var username = Console.ReadLine();
            Console.WriteLine("Password ");
            var password = Console.ReadLine();

            using (UserLoginModelContainer context = new UserLoginModelContainer())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user !=null)
                {
                    if (user.Password == password)
                        Console.WriteLine("Login Completed");
                    else
                        Console.WriteLine("Incorrect Password");
                        Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No user named " + username + " found.");
                    Console.ReadLine();
                }
            }
        }
    }
}
