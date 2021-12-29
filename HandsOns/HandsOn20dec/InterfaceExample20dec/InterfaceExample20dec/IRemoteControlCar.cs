using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample20dec
{
    public interface IRemoteControlCar
    {
        int DistanceTravelled { get; }
        void Drive();
    }
}
