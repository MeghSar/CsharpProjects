using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concat() - We use Concat function to join two, three or four strings.
           
            Console.WriteLine("Concat Method");
            string a1 = "Good";
            string b1 = "Morning";

            String c = String.Concat(a1, b1);

            Console.WriteLine("-> "+c);
            /*If we ever need to join more than 4 strings, we can also pass an array
            of strings to it.*/
            string[] s = { "Go", "od", "Mo", "rn", "ing" };

            String str = String.Concat("-> "+s);

            //_____________________________________________________________________________________
            /*Compare - Compare is a function used to compare two strings and returns
            an integer. */
            Console.WriteLine("\nCompare Method");
            string a2 = "Good";
            string b2 = "Morning";
            string c2 = "Morning";

            int x = String.Compare(a2, b2);// The 1st string precedes the 2nd string in the sort order
            int y = String.Compare(b2, a2);// The 1st string follows the 2nd string in the sort order
            int z = String.Compare(b2, c2);

            Console.WriteLine("-> " + x +" "+ y +" "+z );

            string e = "GoodMorning";
            string f = "goodmorning";

            int x1 = String.Compare(e, f);
            int y1 = String.Compare(e, f, true);//Passing boolean, case will be ignored here

            Console.WriteLine("-> " + x1 + " " + y1);
            

            //_____________________________________________________________________________________
            //Equals - Equals is used to check if two strings have same value or not.
            Console.WriteLine("\n\nEquals Method");
            string a3 = "Good";
            string b3 = "Morning";

            Console.WriteLine("-> " + a3.Equals(b3));

            //_____________________________________________________________________________________
            /*IndexOf - We can use IndexOf method to get the index of any character
            of a string.*/
            Console.WriteLine("\nIndexOf Method");
            string a4 = "GoodMorning";

            Console.WriteLine("-> " + a4.IndexOf('d'));

            //_____________________________________________________________________________________
            /*Relace - Replace is used to replace all occurances of a particular
             character or a string with a different one.*/
            Console.WriteLine("\nReplace Method");
            string a5 = "GoodMorning";
            string b5 = a5.Replace('o', 'd');

            Console.WriteLine("-> " + b5);

            //_____________________________________________________________________________________
            //ToLower - It converts all the characters to lowercase.
            Console.WriteLine("\nToLower Method");
              string a6 = "GoodMorning";
              string b6 = a6.ToLower();

              Console.WriteLine("-> " + b6);

            //_____________________________________________________________________________________
            //ToUpper - It converts all character of a string to uppercase.
            Console.WriteLine("\nToUpper Method");
             string a7 = "GoodMorning";
             string b7 = a7.ToUpper();

             Console.WriteLine("-> " + b7);

            //_____________________________________________________________________________________
            //Remove() - It is used to remove all the characters  from the specified position of a string 
            Console.WriteLine("\nRemove Method");
            String str2 = "GoodMorning";

            Console.WriteLine("Given String : " + str2);

            
            Console.WriteLine("New String1 : " + str2.Remove(5));// delete from index 5 to end of string


            //_____________________________________________________________________________________
            //Trim() - This method is used to removes all leading and trailing white-space characters from the current String object
            Console.WriteLine("\nTrim Method");
            string s1 = " GFG";
            string s2 = " GFG ";
            string s3 = "GFG ";

            // Before Trim method call
            Console.WriteLine("-> Before:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("");

            // After Trim method call
            Console.WriteLine("After:");
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());


            Console.ReadKey();
        }
    }
}
