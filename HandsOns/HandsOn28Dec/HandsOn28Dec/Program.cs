using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn28Dec
{
    class Program

    {
        static void Main(string[] args)
        {
            try
            {
                HandsOnOne h1 = new HandsOnOne();
                h1.CountCharacter();

                HandsOnTwo h2 = new HandsOnTwo();
                h2.Reverse();

                HandsOnThree h3 = new HandsOnThree();
                h3.ReverseOrderString();

                HandsOnFour h4 = new HandsOnFour();
                h4.ReverseEachWord();

                HandsOnFive h5 = new HandsOnFive();
                h5.Substring();

                HandsOnSix h6 = new HandsOnSix();
                h6.SecondLargest();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
