using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityLayer;
using System.Data.SqlClient;

namespace CityBusDataLayer.DBConnection
{
   public class BusDetailsDBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-V9IJS2G;Initial Catalog=CityBusManagementDB;Integrated Security=True";
        public string InsertBus(BusDetailsModel busDetailsObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BusDetailsTable values('" + busDetailsObj.BusName + "'," + busDetailsObj.BusNum + "," + busDetailsObj.RouteNo + ",'" + busDetailsObj.DestArrivalTime + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Bus details saved successfully";
        }
        public string DeleteBus(int busNmb)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from BusDetailsTable where BusNum=" + busNmb + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Bus No " + busNmb + " details deleted successfully";
        }
        public DataTable EditBus(int busNmb)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from BusDetailsTable where BusNum=" + busNmb + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable SelectBus()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from BusDetailsTable", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
