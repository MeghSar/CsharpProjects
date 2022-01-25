using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CityBusDataLayer;
using System.Data;
//using CityBusBusinessLayer;

namespace CityBusBusinessLayer
{
    public class RouteBussiness
    {
       
         public string InsertRoute(RouteMgmtModel routeMgmtModelObj)
         {
            RouteMgmtDBConnection routeMgmtDBConnection = new RouteMgmtDBConnection();
            string msg = routeMgmtDBConnection.InsertRoute(routeMgmtModelObj);
            return msg;
         }
        public string DeleteRoute(int routeNo)
        {
            RouteMgmtDBConnection routeMgmtDBConnection = new RouteMgmtDBConnection();
            string msg = routeMgmtDBConnection.DeleteRoute(routeNo);
            return msg;
        }
        public DataTable EditRoute(int routeNo)
        {
            RouteMgmtDBConnection routeMgmtDBConnection = new RouteMgmtDBConnection();
            DataTable dt = routeMgmtDBConnection.EditRoute(routeNo);
            return dt;
        }


        public DataTable SelectTable()
        {
            RouteMgmtDBConnection routeMgmtDBConnection = new RouteMgmtDBConnection();
            DataTable dt = routeMgmtDBConnection.SelectTable();
            return dt;
        }

    }
}
