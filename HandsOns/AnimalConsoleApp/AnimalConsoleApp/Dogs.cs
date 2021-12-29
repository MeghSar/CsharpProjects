using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalConsoleApp
{
    class Dogs
    {
        private int lg,er,tl;
        private string bark;
        public string Body(int leg,int ear,int tail)
        {
            lg = leg;
            er = ear;
            tl = tail;
            string str = "Dogs have " + lg + " legs " + er + " ears and " + tl + " tail.";
            return str;
        }
        public string Bark()
        {
            bark = "Dog barks...";
            return bark;
        }
        public Dogs()
        {
            Console.WriteLine("Parent Class constructor invoked...");
            Console.WriteLine("\nI am the Dogs() Constructor.");
            Console.WriteLine("Dogs are...\n 1.Good Family Pet.\n 2.Good Guards.\n 3.Loyal Companion.\n 4.Courageous.");

        }

    }
}
