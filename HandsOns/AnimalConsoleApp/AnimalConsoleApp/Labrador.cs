using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalConsoleApp
{
    class Labrador:Dogs
    {
        private string brk;
        public string Bark()
        {
            brk = "Labrador barks...";
            return brk;
        }
        public void Nature()
        {
            Console.WriteLine("The Labrador has the reputation of being one of the most sweet-natured breeds.");
        }

    }
}
