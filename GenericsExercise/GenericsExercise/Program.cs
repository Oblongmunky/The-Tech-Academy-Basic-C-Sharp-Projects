using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();

            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();

            stringList.Add("Jeremy");
            stringList.Add("Andrea");
            intList.Add(1);
            intList.Add(2);

            employee1.Things = stringList;
            employee2.Things = intList;

            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
