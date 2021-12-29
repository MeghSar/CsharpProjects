using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnFive
    {
        public void Substring()
        {
            Console.WriteLine("\n\nEnter a string to find substring - ");
            string myString = Console.ReadLine();
            int l = myString.Length;
            char[] charArray = new char[l];
            
            for (int i = 0; i < l; i++)
            {
                charArray[i] = myString[i];
            }
            for (int k = 0; k <= l; k++)
            {
                for (int i = k; i <= l; i++)
                {
                    for (int j = k; j < i; j++)
                    {
                        Console.Write(charArray[j]);
                    }
                   Console.Write(" ");
                    
                }
            }
        }
    }
}