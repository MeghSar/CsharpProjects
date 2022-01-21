using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CityBusBusinessLayer;
using EntityLayer;
using CityBusDataLayer;

namespace CityBusManagementSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            RouteMgmtDBConnection routeMgmtDBConnectionObj = new RouteMgmtDBConnection();
            RouteMgmtModel routeMgmtModelObj = new RouteMgmtModel();

            routeMgmtModelObj.RouteNo = Convert.ToInt32(TxtRouteNo.Text);
            routeMgmtModelObj.StopNum = Convert.ToInt32(TxtNumOfStops.Text);
            routeMgmtModelObj.Fare = Convert.ToInt32(TxtFare.Text);
            routeMgmtModelObj.BegnStop = TxtBegStop.Text;
            routeMgmtModelObj.EndStop = TxtEndStop.Text;
            routeMgmtModelObj.StartTime = TextStartTime.Text;
            routeMgmtModelObj.EndTime = TextEndTime.Text;
           

            string msg = routeMgmtDBConnectionObj.InsertRoute(routeMgmtModelObj);
            lblMsg.Text = msg;

            LoadData();
        }
        public void LoadData()
        {
            RouteMgmtDBConnection routeMgmtDBConnectionObj = new RouteMgmtDBConnection();
            DataTable dtResult = routeMgmtDBConnectionObj.SelectTutorial();
            gvResult.DataSource = dtResult;
            gvResult.DataBind();
        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            RouteMgmtDBConnection routeMgmtDBConnectionObj = new RouteMgmtDBConnection();
            string msg = routeMgmtDBConnectionObj.DeleteRoute(Convert.ToInt32(TxtRouteNo.Text));
            lblMsg.Text = msg;

            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            RouteMgmtDBConnection routeMgmtDBConnectionObj = new RouteMgmtDBConnection();
            DataTable dtResult = routeMgmtDBConnectionObj.EditRoute(Convert.ToInt32(TxtRouteNo.Text));
            TxtNumOfStops.Text = dtResult.Rows[0][1].ToString();
            TxtFare.Text = dtResult.Rows[0][2].ToString();
            TxtBegStop.Text = dtResult.Rows[0][3].ToString();
            TxtEndStop.Text= dtResult.Rows[0][4].ToString();
            TextStartTime.Text = dtResult.Rows[0][5].ToString();
            TextEndTime.Text = dtResult.Rows[0][6].ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
          

        }
    }
}