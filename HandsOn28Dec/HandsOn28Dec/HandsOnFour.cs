using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnFour
    {
        public void ReverseEachWord()
        {
            Console.WriteLine("\nEnter a string to reverse the words in the string - ");
            string myString = Console.ReadLine();
            string[] stringArray = myString.Split(' ');
         

            int l1 = stringArray.Length;

            
            for (int i = 0; i< l1 ; i++)
            {

                Console.Write(Rev(stringArray[i])+" ");

            }
            
        }
        public string Rev(string s)
        {
            char[] revStrings = s.ToCharArray();
            Array.Reverse(revStrings);
            return new string(revStrings);
        }
    }
}
