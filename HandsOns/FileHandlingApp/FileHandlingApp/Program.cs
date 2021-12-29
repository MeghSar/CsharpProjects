using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseFile houseFileObj = new HouseFile();
            houseFileObj.CreatHouse();
            Console.ReadKey();
        }
    }
}
