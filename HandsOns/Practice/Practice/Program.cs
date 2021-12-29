using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for(int i = 0;i<num;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);

            }*/


            // 1st Program
            /* int[] arr = { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };

             foreach(var item in arr)
             {
                 if ((item > 30) && (item < 100))
                 {
                     Console.Write(item + " ");
                 }
             }*/
            /*List<int> list = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };
            foreach(var item in list)
            {
               if((item > 30)&&(item< 100))
                {
                    Console.Write(item+" ");
                }
            }*/
           /*  //2nd Program
             List<string> str = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };
             foreach(var item in str)
             {
                if(item.Length == 5)
                {
                    Console.WriteLine(item.ToUpper());
                }
             }*/
           for(int i = 0; i < 2; ++i)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
