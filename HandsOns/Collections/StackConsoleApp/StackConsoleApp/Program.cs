using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stack

            Stack peronStack = new Stack();
            Console.WriteLine("STACK EXAMPLE\n");
            Console.WriteLine("Number of persons:");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name and age below:\n");
            for (int i = 0; i < total; i++)
            {
                String name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());

                Person personObj = new Person();
                peronStack.Push(personObj.ToString(name, age));
            }
            Console.WriteLine("\nOutput:\n");
            foreach(var element in peronStack)
            {
                Console.WriteLine(element);
            }
            #endregion
            #region queue
            Console.WriteLine("_________________________________________\n");
            Queue personQ = new Queue();
            Console.WriteLine("QUEUE EXAMPLE\n");
            Console.WriteLine("Number of persons:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name and age below:\n");
            for (int i = 0; i < total; i++)
            {
                String name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());

                Person personObj1 = new Person();
                personQ.Enqueue(personObj1.ToString(name, age));
            }
            Console.WriteLine("\nOutput:\n");
            foreach (var element in personQ)
            {
                Console.WriteLine(element);
            }
            #endregion
            Console.ReadKey();
        }

    }
}
