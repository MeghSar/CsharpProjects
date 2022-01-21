using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityBusDataLayer.DBConnection;
using EntityLayer;


namespace CityBusManagementSystem
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {

            EmployeeDBConnection empDBConObj = new EmployeeDBConnection();
            EmployeeModel employeeModelObj = new EmployeeModel();

            employeeModelObj.EmployeeID = Convert.ToInt32(TextEmpId.Text);
            employeeModelObj.EmployeeName = TextEmpName.Text;
            employeeModelObj.EmployeeDesig = TextEmpDesig.Text;
            


            string msg = empDBConObj.InsertRoute(employeeModelObj);
            lblEmployee.Text = msg;

            LoadData();
        }
        public void LoadData()
        {
            EmployeeDBConnection empDBConObj = new EmployeeDBConnection();
            DataTable dtResult = empDBConObj.SelectEmployee();
            gvEmployee.DataSource = dtResult;
            gvEmployee.DataBind();
        }
    }
}