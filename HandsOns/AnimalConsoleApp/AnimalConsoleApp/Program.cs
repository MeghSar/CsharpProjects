using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Labrador(Child) Class object...\n");
            Labrador lab = new Labrador();
            Console.WriteLine("\nCalling labrador class method...");
            Console.WriteLine(lab.Bark());

            Console.WriteLine("_________________________________________");

            Console.WriteLine("Creating Dogs(Parent) Class object...\n");
            Dogs dog = new Dogs();
            Console.WriteLine("\nCalling Dogs class method...");
            Console.WriteLine(dog.Body(4, 2, 1));

            Console.ReadKey();

        }
    }
}
