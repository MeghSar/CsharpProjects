using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileHandlingAssignmentCS
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsRead = new FileStream("E:\\Capgemini\\.Net core\\Assignment\\Assignment1\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader srObj = new StreamReader(fsRead);
            Console.WriteLine("ID\t\tSource\t\t\tDestination\t\tDate\t\t\tStatus\t\tNetwork");

            while (srObj.Peek() > 0)
            {
                string str;
                string[] strArray;

                str = srObj.ReadLine();
                strArray = str.Split(':');

                if (str != "")
                {
                    if (strArray.Length > 1)
                    {
                        if (str.StartsWith("Date"))
                        {
                            String date = strArray[1].Split(' ')[0];
                            Console.Write(date + "\t\t");
                        }
                        else
                            Console.Write(strArray[1] + "\t\t");

                    }
                   
                }
                else
                    Console.WriteLine();
            }
    
            srObj.Close();
            fsRead.Close();
           Console.ReadKey();
        }
    }
}
