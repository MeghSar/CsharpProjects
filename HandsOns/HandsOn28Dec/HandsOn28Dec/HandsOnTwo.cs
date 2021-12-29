using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnTwo
    {
        public void Reverse()
        {
            Console.WriteLine("\nEnter a string to reverse - ");
            string myString = Console.ReadLine();
            char[] charArray = new char[myString.Length];
            string rev = "";

            int l = myString.Length;
            for (int i = 0; i < l; i++)
            {
                charArray[i] = myString[i];
            }

            for (int i = l-1; i >= 0; i--)
            {
                rev = rev + charArray[i];
            }
            Console.WriteLine(rev);
        }
    }
}
