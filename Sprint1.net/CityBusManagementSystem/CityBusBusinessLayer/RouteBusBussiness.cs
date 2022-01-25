using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityBusDataLayer;

namespace CityBusBusinessLayer
{
    public class RouteBusBussiness
    {
      
        public DataTable SearchBusDetailsByBusName(string busName)
        {
            RouteBusDBConnection routeBusDBConnectionObj = new RouteBusDBConnection();
            DataTable dt = routeBusDBConnectionObj.SearchBusDetailsByBusName(busName);
            return dt;
        }
        public DataTable SearchRouteDetailsByBusName(string busName)
        {
            RouteBusDBConnection routeBusDBConnectionObj = new RouteBusDBConnection();
            DataTable dt = routeBusDBConnectionObj.SearchRouteDetailsByBusName(busName);
            
            return dt;
        }
    }
}
