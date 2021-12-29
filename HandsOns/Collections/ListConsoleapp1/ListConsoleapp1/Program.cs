using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListConsoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region program1
            /*  List<int> list = new List<int>();
              list.Add(1);
              list.Add(2);
              list.Add(3);
              list.Add(4);
              list.Add(5);

              foreach(var item in list)
              {
                  Console.Write((5 * (2 + item))+" ");
              }*/
            #endregion
            #region program2
            /* List<string> list2 = new List<string>();
             list2.Add("1");
             list2.Add("2");
             list2.Add("3");
             list2.Add("4");
             list2.Add("5");

             foreach (var item in list2)
             {
                 Console.Write((item+item+item+item)+" ");            
             }*/
            #endregion
            #region program3
            List<string> list3 = new List<string>();
            list3.Add("abc");
            list3.Add("cdaef");
            list3.Add("js");
            list3.Add("php");
            
            foreach (var item in list3)
            {
                Console.Write((item.Replace("a", "")) +" ");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
