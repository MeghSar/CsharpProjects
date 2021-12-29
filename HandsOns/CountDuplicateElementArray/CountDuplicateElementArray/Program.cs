using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDuplicateElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] dup = new int[10];
            int i;
            int count1,count2=0;

            Console.WriteLine("Counting Duplicate Array Elements");
            Console.WriteLine("_________________________________");

            Console.WriteLine("Enter 10 Array Elements:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("array[{0}]", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Elements Are:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
                
            }
            Console.WriteLine("Counting duplicate elements...\n");
            for (i = 0; i < 10; i++)
            {
                count1 = 0;
                for(int j = 1; j < 10; j++)
                {
                    if (array[i] == array[j])
                       Console.Write(count1++);
                }    
            }

            Console.WriteLine("{0}", count2++);
            Console.ReadKey();
        }
    }
}
