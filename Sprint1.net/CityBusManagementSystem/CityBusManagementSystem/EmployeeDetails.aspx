<%@ Page Title="City Bus | Employee Details" Language="C#" MasterPageFile="~/CityBusMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="CityBusManagementSystem.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
        #Employee{
            justify-content:center;
            display:flex;
        }
         #grid{
            justify-content:center;
            display:flex;
            
            
        }
     
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:aliceblue" id="Employee">
        <table>
            <tr>
                <td>
                <asp:Label ID="Label1" runat="server" Text="Employee Id"></asp:Label>
               </td>
                <td>
                <asp:TextBox ID="TextEmpId" runat="server" Width="225px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>
                <asp:Label ID="Label2" runat="server" Text="Employee Name"></asp:Label>
               </td>
                <td>
                <asp:TextBox ID="TextEmpName" runat="server" Width="224px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>
                <asp:Label ID="Label3" runat="server" Text="Designation"></asp:Label>
               </td>
                <td>
                <asp:TextBox ID="TextEmpDesig" runat="server" Width="224px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td>
                <asp:Button ID="btnSaveEmployee" runat="server" Text="Save" BackColor="#9999ff" Width="234px" OnClick="btnSaveEmployee_Click" />
               </td>
                <td>
                <asp:Button ID="btnDeleteEmployee" runat="server" Text="Delete" BackColor="#9999ff" Width="234px"/>
                 </td>
            </tr>
        </table>
        <asp:GridView ID="gvEmployee" runat="server"></asp:GridView>
         </div>
    <div id="grid">
        <asp:Label ID="lblEmployee" runat="server" Text=""></asp:Label>
        
   </div>
</asp:Content>
