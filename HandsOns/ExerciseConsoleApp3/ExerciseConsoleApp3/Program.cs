using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i;
            int sum = 0;
            int n;

            Console.WriteLine("Sum of all elements in an array");
            Console.WriteLine("_______________________________");

            Console.Write("\nNumber of array elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEntering {0} elements in array : ",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("\nElement {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nPrinting elements in array : ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" ");
                Console.Write(arr[i]);
            }

            for (i = 0; i < n; i++)
            {
                sum += arr[i];
               
            }

            Console.WriteLine("\n\nSum of elements in array : ");
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
