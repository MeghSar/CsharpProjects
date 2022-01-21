using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBusDataLayer
{
    public class RouteMgmtModel
    {
        public int RouteNo { get; set; }
        public int StopNum { get; set; }
        public int Fare { get; set; }
        public string BegnStop { get; set; }
        public string EndStop { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }


    }
}
