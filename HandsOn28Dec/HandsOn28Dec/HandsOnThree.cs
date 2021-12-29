using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnThree
    {
        public void ReverseOrderString()
        {
            Console.WriteLine("\nEnter a string to reverse the order - ");
            string myString = Console.ReadLine();
            string[] stringArray = myString.Split(' ');
            string rev = "";

            int l = stringArray.Length;
            for (int i = l - 1; i >= 0; i--)
            {
                rev = rev + stringArray[i]+" ";
            }
            Console.WriteLine(rev+" ");
        }
    }
}
