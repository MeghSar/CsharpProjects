using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class HandsOnOne
    {
        public void CountCharacter()
        {
            Console.WriteLine("Enter a string to count each character's occurance -");
            string myString = Console.ReadLine();
            char[] charArray = new char[myString.Length];
            string[] s=new string[myString.Length] ;
            
            string str = "";
            for (int i = 0; i < myString.Length; i++)
               {
                   charArray[i] = myString[i];
               }
            for (int i = 0; i < myString.Length; i++)
            {

                int count = 0;

                for (int j = 0; j < myString.Length; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        count++;
                    }
                    
                }

                    str = charArray[i] + " - " + count;

                    s[i] = str;
                

            }
            
            string[] store = s.Distinct().ToArray();
         
            foreach(var item in store)
            {
                if (item.StartsWith(" "))
                    Console.Write("");
                else
                    Console.WriteLine(item);
                
                
            }
        }
    }
}
