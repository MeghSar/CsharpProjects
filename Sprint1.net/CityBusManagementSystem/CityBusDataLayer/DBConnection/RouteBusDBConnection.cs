using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace CityBusDataLayer
{
   public class RouteBusDBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-V9IJS2G;Initial Catalog=CityBusManagementDB;Integrated Security=True";
   
        public DataTable SearchBusDetailsByBusName(string busName)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select BusName,BusNum,DestArrivalTime from BusDetailsTable where BusName = '" + busName + "'", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
           
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable SearchRouteDetailsByBusName(string busName)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select RouteNo,StopNum,Fare,BegnStop,EndStop from RoutDetailsTable where RouteNo = (select RouteNo from BusDetailsTable where BusName ='" + busName + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            
            sqlConnectionObj.Close();
            return dt;
        }
    }
}
