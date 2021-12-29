using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample20dec
{
    static class TestTrack
    {
        public static void Race(IRemoteControlCar carRace)
        {
            carRace.Drive();
        }
        public static int GetRankedCars(ProductionRemoteControlCar p1,ProductionRemoteControlCar p2)
        {
            int v=0;
            if(p1.CompareTo(p2)> 0)
            {
                v = p1.NumberOfVictories;
                Console.WriteLine("Rank 1 - pcr1");
                return v;
            }
            else if (p1.CompareTo(p2) < 0)
            {
                v = p2.NumberOfVictories;
                Console.WriteLine("Rank 1 - pcr2");
                return v;
            }
            else
            {
                Console.WriteLine("Same Rank");
                return v;
            }
            
        }
    }
}




