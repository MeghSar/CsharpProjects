using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnSix
    {
        public void SecondLargest()
        {
            Console.WriteLine("\n\nNumber of elemnts you want to enter to find second highest - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = n + (n - 1);
            try
            {
                Console.WriteLine("Enter Elements - ");
                string myString = Console.ReadLine();
                if(myString.Length > max)
                {
                    Console.WriteLine("You Should Enter {0} number of elements .", n);
                    SecondLargest();
                }
                string[] splited = myString.Split(' ');
                int len = n;
                int[] num = new int[len];
           
                for (int i = 0; i < n; i++)
                {
                    num[i] = Convert.ToInt32(splited[i]);
                }
                Array.Sort(num);
                Console.WriteLine(num[n-2]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Enter the numbers in 1 line");
                SecondLargest();
            }
            
        }
    }
}
