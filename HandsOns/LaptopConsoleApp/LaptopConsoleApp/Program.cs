using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nm, pr, prcsr, rm, hdd;
            LaptopDetails lap = new LaptopDetails();
            Console.WriteLine("Enter Laptop Details Below...\n");

            Console.Write("Name : ");
            nm = Console.ReadLine();
            Console.Write("Price : $");
            pr = Console.ReadLine();
            Console.Write("Processor : ");
            prcsr = Console.ReadLine();
            Console.Write("RAM : ");
            rm = Console.ReadLine();
            Console.Write("Hard Disk Drive : ");
            hdd = Console.ReadLine();

            lap.ShowDetails(nm,pr,prcsr,rm,hdd);
            Console.ReadKey();
        }
    }
}
