using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            int id;
            int num;

            Console.Write("Enter your details in following manner.\n\n");
            Console.Write("First_Name Last_Name ID\nnumber_of_scores\nscore1 score2 score3 ...\n\n");
            Console.WriteLine("INPUT\n_________________________");
            var line = Console.ReadLine();
            var lineData = line.Split(' ');
            fname = string.Copy(lineData[0]);
            lname = string.Copy(lineData[1]);
            id = int.Parse(lineData[2]);

            num = Convert.ToInt32(Console.ReadLine());
            var stringArray = Console.ReadLine().Split(' ');
            var scores = new int[num];
            for (int i = 0; i < num; i++)
            {
                scores[i] = int.Parse(stringArray[i]);
                //scores[i]= Convert.ToInt32(Console.ReadLine());
            }
            Student stud = new Student(fname, lname, id, scores);
            Console.WriteLine("\n\nOUTPUT\n_________________________");
            stud.PrintPersonData();
            Console.WriteLine("Grade: " + stud.Calculate());
            Console.ReadKey();
        }
    }
}
