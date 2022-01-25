using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityBusDataLayer.DBConnection;
using EntityLayer;
using CityBusBusinessLayer;


namespace CityBusManagementSystem
{
    public partial class BusDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusBussiness busBussinessObj = new BusBussiness();
            BusDetailsModel busModelObj = new BusDetailsModel();

            busModelObj.BusName = txtBusName.Text;
            busModelObj.BusNum = Convert.ToInt32(txtBusNum.Text);
            busModelObj.RouteNo = Convert.ToInt32(txtRouteNo.Text);
            busModelObj.DestArrivalTime = txtArrival.Text;

            string msg = busBussinessObj.InsertBus(busModelObj);
            DataTable dtUserInfo = busBussinessObj.SelectBus();


            LoadData();
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            BusDetailsDBConnection busDBConObj = new BusDetailsDBConnection();
            DataTable dtResult = busDBConObj.EditBus(Convert.ToInt32(txtBusNum.Text));
            txtBusName.Text = dtResult.Rows[0][0].ToString();
            txtRouteNo.Text = dtResult.Rows[0][2].ToString();
            txtArrival.Text = dtResult.Rows[0][3].ToString();
           
        }
        public void LoadData()
        {
            BusDetailsDBConnection busDBConObj = new BusDetailsDBConnection();
            DataTable dtResult = busDBConObj.SelectBus();
            gvBus.DataSource = dtResult;
            gvBus.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BusDetailsDBConnection busDBConObj = new BusDetailsDBConnection();
            string msg = busDBConObj.DeleteBus(Convert.ToInt32(txtBusNum.Text));
            lblBusDetails.Text = msg;

            LoadData();
        }

        
    }
}