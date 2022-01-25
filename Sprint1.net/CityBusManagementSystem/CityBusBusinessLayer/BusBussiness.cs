using CityBusDataLayer.DBConnection;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBusBusinessLayer
{
    public class BusBussiness
    {
        public string InsertBus(BusDetailsModel busDetailsObj)
        {
            BusDetailsDBConnection routeMgmtDBConnection = new BusDetailsDBConnection();
            string msg = routeMgmtDBConnection.InsertBus(busDetailsObj);
            return msg;
        }
        public string DeleteBus(int busNmb)
        {
            BusDetailsDBConnection routeMgmtDBConnection = new BusDetailsDBConnection();
            string msg = routeMgmtDBConnection.DeleteBus(busNmb);
            return msg;
        }
        public DataTable EditBus(int busNmb)
        {

            BusDetailsDBConnection routeMgmtDBConnection = new BusDetailsDBConnection();
            DataTable dt = routeMgmtDBConnection.EditBus(busNmb);
            return dt;
        }
        public DataTable SelectBus()
        {

            BusDetailsDBConnection routeMgmtDBConnection = new BusDetailsDBConnection();
            DataTable dt = routeMgmtDBConnection.SelectBus();
            return dt;
        }
    }
}
