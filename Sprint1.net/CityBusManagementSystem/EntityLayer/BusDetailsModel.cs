using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BusDetailsModel
    {
        public string BusName { get; set; }
        public int BusNum { get; set; }
        public int RouteNo { get; set; }
        public string DestArrivalTime { get; set; }
    }
}
