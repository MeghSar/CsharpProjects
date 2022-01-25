using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace CityBusDataLayer
{
    public class RouteMgmtDBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-V9IJS2G;Initial Catalog=CityBusManagementDB;Integrated Security=True";
        public string InsertRoute(RouteMgmtModel routeMgmtModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into RoutDetailsTable values(" + routeMgmtModelObj.RouteNo + "," + routeMgmtModelObj.StopNum + "," + routeMgmtModelObj.Fare + ",'" + routeMgmtModelObj.BegnStop + "','" + routeMgmtModelObj.EndStop + "','" + routeMgmtModelObj.StartTime + "','" + routeMgmtModelObj.EndTime + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Route details saved successfully";
        }
        public string DeleteRoute(int routeNo)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from RoutDetailsTable where RouteNo=" + routeNo + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Route No " + routeNo + " details deleted successfully";
        }
        public DataTable EditRoute(int routeNo)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from RoutDetailsTable where RouteNo=" + routeNo + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
       

        public DataTable SelectTable()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from RoutDetailsTable", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }

}
