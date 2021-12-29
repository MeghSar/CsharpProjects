using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample20dec
{
    class ExperimentalRemoteControlCar: IRemoteControlCar
    {
        public int DistanceTravelled { get; set; }
        public int NumberOfVictories { get; set; }
        public void Drive()
        {
            Random r = new Random();
            int num = r.Next(10);
            DistanceTravelled = num;
        }
    }
}
