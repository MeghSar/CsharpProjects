<%@ Page Title="City Bus | Route Management" Language="C#" AutoEventWireup="true" MasterPageFile="~/CityBusMaster.Master" CodeBehind="RouteManagement.aspx.cs" Inherits="CityBusManagementSystem.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .route{
            justify-content:center;
            display:flex;
            background-color:white;
        }
      .colorChange:hover{
          border-color:midnightblue;
          color:midnightblue;
      }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="route">
        <div style="background-color:aliceblue">
            <table>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Route Number"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtRouteNo" runat="server" Width="231px"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Number Of Stops"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtNumOfStops" runat="server" Width="230px"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Fare Stages"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtFare" runat="server" Width="230px"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Beginning Stoppage"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtBegStop" runat="server" Width="229px"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label5" runat="server" Text="Ending Stoppage"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtEndStop" runat="server" Width="229px"></asp:TextBox>

                   </td>
               </tr>
                 <tr>
                   <td>
                       <asp:Label ID="Label6" runat="server" Text="Start Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TextStartTime" runat="server" Width="229px"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label7" runat="server" Text="End Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TextEndTime" runat="server" Width="229px"></asp:TextBox>

                   </td>
               </tr>
            </table>
            <asp:Button Class="colorChange" ID="BtnSave" runat="server" Text="Save" Width="80px" OnClick="BtnSave_Click" BackColor="#9999ff" />
            <asp:Button Class="colorChange" ID="Btndelete" runat="server" Text="Delete" Width="86px" OnClick="Btndelete_Click" BackColor="#9999ff" />
            <asp:Button Class="colorChange" ID="BtnEdit" runat="server" Text="Edit" Width="99px" OnClick="BtnEdit_Click" BackColor="#9999ff" />
            <asp:Button Class="colorChange" ID="BtnExit" runat="server" Text="Exit" Width="98px" BackColor="#9999ff" />
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtBusNm" placeholder="Enter Bus Name to get details" runat="server" Width="176px" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button Class="colorChange" ID="btnSearch" runat="server" Text="Search" Width="74px" BackColor="#9999ff" OnClick="btnSearch_Click" />
                    </td>
                    <td>
                        <asp:Button Class="colorChange" ID="btnReload" runat="server" Text="Reload Routes" BackColor="#9999ff" OnClick="btnReload_Click" Width="108px" /> 
                    </td>
                </tr>
            </table>
            
        </div>
        <div>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            <asp:GridView ID="gvBusDetails" runat="server"></asp:GridView>
            <asp:GridView ID="gvResult" runat="server"></asp:GridView>
            
        </div>
      </div> 
  
</asp:Content>