using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();
            Employee e5 = new Employee();
            Employee e6 = new Employee();
            Employee e7 = new Employee();
            Employee e8 = new Employee();
            Employee e9 = new Employee();
            Employee e10 = new Employee();

            e1.firstName = "Jeremy";
            e1.lastName = "Grundy";
            e1.id = 1;
            e2.firstName = "Andrea";
            e2.lastName = "Brewer";
            e2.id = 2;
            e3.firstName = "Harper";
            e3.lastName = "Brewer Grundy";
            e3.id = 3;
            e4.firstName = "Chris";
            e4.lastName = "Duperron";
            e4.id = 4;
            e5.firstName = "Mike";
            e5.lastName = "Wardle";
            e5.id = 5;
            e6.firstName = "Andrew";
            e6.lastName = "Hassold";
            e6.id = 6;
            e7.firstName = "Joe";
            e7.lastName = "Smith";
            e7.id = 7;
            e8.firstName = "Steve";
            e8.lastName = "Johnson";
            e8.id = 8;
            e9.firstName = "Bob";
            e9.lastName = "Freeman";
            e9.id = 9;
            e10.firstName = "Joe";
            e10.lastName = "Anderson";
            e10.id = 10;


            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);
            employees.Add(e6);
            employees.Add(e7);
            employees.Add(e8);
            employees.Add(e9);
            employees.Add(e10);

            List<Employee> nJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    nJoe.Add(employee);
                }
            }

            List<Employee> lJoe = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> gtFive = employees.Where(x => x.id > 5).ToList();

            Console.WriteLine(nJoe.Count);
            Console.WriteLine(lJoe.Count);
            Console.WriteLine(gtFive.Count);

            Console.ReadLine();
        }
    }
}
