using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CityBusDataLayer;

namespace CityBusBusinessLayer
{
    public class Connect
    {
        Connect conObj = new Connect();
         public void ConnectLayers(RouteMgmtDBConnection routeMgmtObj)
         {
             conObj.ConnectLayers(routeMgmtObj);
         }
        
    }
}
