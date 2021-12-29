using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TextSplitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string str;
            string[] strArray;


            FileStream fsRead = new FileStream("E:\\Capgemini\\.Net core\\.Net Core Projects\\SplitStoreinArray\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader srObj = new StreamReader(fsRead);
            Console.WriteLine("ID\t\tSource\t\t\tDestination\t\tDate\t\t\tStatus\t\tNetwork");
            string line = File.ReadAllText(@"E:\Capgemini\.Net core\.Net Core Projects\SplitStoreinArray\networklog.txt");
            int totalRecords = Regex.Matches(line, @"\bId\b").Count;
            string[] srcArray = new string[totalRecords];
            string[] destArray = new string[totalRecords];
            string[] dtArray = new string[totalRecords];
            string[] stsArray = new string[totalRecords];
            string[] ntwrkArray = new string[totalRecords];
            
            int[] idArray = new int[totalRecords];
            while (srObj.Peek() > 0)
                {
               
                    str = srObj.ReadLine();
                    strArray = str.Split(':');

                if (str.StartsWith("Id"))
                {
                    
                        idArray[i] = Convert.ToInt32(strArray[1]);
                    
                }
                else if (str.StartsWith("Source"))
                {

                    srcArray[i] = strArray[1];

                }
                else if (str.StartsWith("Destination"))
                {

                    destArray[i] = strArray[1];

                }
                else if (str.StartsWith("Date"))
                {
                    if (strArray.Length > 1)
                    {
                        if (str.StartsWith("Date"))
                        {
                            String date = strArray[1].Split(' ')[0];
                            dtArray[i] = date;
                        }
                    }
                }
                else if (str.StartsWith("Status"))
                {

                    stsArray[i] = strArray[1];

                }
                else if (str.StartsWith("Network"))
                {
                    ntwrkArray[i] = strArray[1];
                }
                else
                {
                    i++;
                }

               
            }

            for(int j = 0; j < totalRecords; j++)
            {
                Console.Write(idArray[j] + "\t\t");
                Console.Write(srcArray[j] + "\t\t");
                Console.Write(destArray[j] + "\t\t");
                Console.Write(dtArray[j] + "\t\t");
                Console.Write(stsArray[j] + "\t\t");
                Console.Write(ntwrkArray[j] + "\n");
            }

            srObj.Close();
            fsRead.Close();
            Console.ReadKey();
            
        }
        
    }
    
}

