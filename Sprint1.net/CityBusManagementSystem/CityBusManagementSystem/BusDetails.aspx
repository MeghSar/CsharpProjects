<%@ Page Title="City Bus | Bus Details" Language="C#" AutoEventWireup="true" MasterPageFile="~/CityBusMaster.Master" CodeBehind="BusDetails.aspx.cs" Inherits="CityBusManagementSystem.BusDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }
        .bus{
            justify-content:center;
            display:flex;
            background-color:white;
        }
      
      .colorChange:hover
        {
            border-color:darkblue;
            color:darkblue;
        }
     
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="bus" style="background-color:aliceblue">
         
        <div>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Bus Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBusName" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Bus Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBusNum" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Route Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRouteNo" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                 <asp:Label ID="Label4" runat="server" Text="Arrival Time"></asp:Label> 

                </td>
                <td>
                    <asp:TextBox ID="txtArrival" runat="server" Width="183px"></asp:TextBox>
                </td>
            </tr>
            
        </table>
         <asp:Button class="colorChange" ID="btnAdd" runat="server" Text="Add" Width="68px" BackColor="#9999ff" />
        <asp:Button class="colorChange" ID="btnDelete" runat="server" Text="Delete" Width="64px" BackColor="#9999ff" OnClick="btnDelete_Click" />
        <asp:Button class="colorChange" ID="btnSave" runat="server" Text="Save" Width="70px" BackColor="#9999ff" OnClick="btnSave_Click"/>
        <asp:Button class="colorChange" ID="btnEdit" runat="server" Text="Edit" Width="85px" BackColor="#9999ff" OnClick="btnEdit_Click" />
         </div>
      <div>
        <asp:GridView ID="gvBus" runat="server"></asp:GridView>
         <asp:Label ID="lblBusDetails" runat="server" Text=""></asp:Label>        
     </div>
         
       
    </div>
       
   
    
    
</asp:Content>