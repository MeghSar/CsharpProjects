using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace CityBusDataLayer.DBConnection
{
    public class EmployeeDBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-V9IJS2G;Initial Catalog=CityBusManagementDB;Integrated Security=True";
        public string InsertRoute(EmployeeModel empObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into EmployeeTable values(" + empObj.EmployeeID + ",'" + empObj.EmployeeName + "','" + empObj.EmployeeDesig + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Employee details saved successfully";
        }
        public DataTable SelectEmployee()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from EmployeeTable", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
