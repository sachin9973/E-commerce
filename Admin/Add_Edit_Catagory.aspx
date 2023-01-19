<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Add_Edit_Catagory.aspx.cs" Inherits="E_commerce.Admin.Add_Edit_Catagory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Catagory</h1>
    <label>Catagory Name</label>
    <asp:TextBox ID="txtCatName" runat="server"></asp:TextBox>
    <br />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
    <asp:Button ID="btn_AddCatagory" runat="server" Text="Add Catagory" OnClick="btn_AddCatagory_Click" /><br />
    <hr />

    <asp:GridView ID="GridView1" runat="server" width="100%"  AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Cat_id" HeaderText="Cat_id" ReadOnly="True" />
            <asp:BoundField DataField="Catagory_name" HeaderText="Catagory_name" />
            <asp:BoundField DataField="Mode" HeaderText="Mode" />
            <asp:BoundField />
            <asp:CommandField HeaderText="Manage" ShowEditButton="True" />
            <asp:CommandField HeaderText="Manage" ShowDeleteButton="True" />
        </Columns>

        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />

    </asp:GridView>
</asp:Content>
