using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();
            Console.WriteLine("ARRAYLIST EXAMPLE\n");
            Console.WriteLine("Number of persons:");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name and age below:\n");
            for(int i = 0; i < total; i++)
            {
                String name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());

                Person personObj = new Person();
                personList.Add(personObj.ToString(name, age));
            }
            Console.WriteLine("\nOutput:\n");
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine(personList[i]);
            }
            Console.ReadKey();
        }
    }
}
