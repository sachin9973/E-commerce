<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Add_Edit_SubCatagory.aspx.cs" Inherits="E_commerce.Admin.Add_Edit_SubCatagory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Sub Catagory</h1>
    <asp:Label ID="Label2" runat="server" Text="Label">Catagory</asp:Label>

    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList><br />
    <asp:Label ID="Label1" runat="server" Text="Label">Sub Catagory</asp:Label>
    <asp:TextBox ID="txtSub" runat="server"></asp:TextBox>
    <br />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <asp:Button ID="Button1" runat="server" Text="Add " OnClick="Button1_Click" />
    <br />
    <hr />
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="Subcat_id" HeaderText="Subcat_id" ReadOnly="True" />
            <asp:BoundField DataField="Subcat_Name" HeaderText="Subcat_Name" />
            <asp:CommandField HeaderText="Manage" ShowEditButton="True" />
            <asp:CommandField HeaderText="Manage" ShowDeleteButton="True" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>

    </asp:GridView>
</asp:Content>
