using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5];
            int[] a2 = new int[5];
            int i;

            Console.WriteLine("Enter 5 array elemnts : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("\nElement-{0} : ", i);
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Copying elements of one array to another array ... ");
            for (i = 0; i < 5; i++)
            {
                a2[i] = a1[i];
                Console.Write("\nElement-{0} copied. ", i);
            } 
            
            Console.WriteLine("Printing elemnts of second array... ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", a2[i]);
            }

            Console.ReadKey();
        }
    }
}
