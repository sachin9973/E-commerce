<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="E_commerce.Admin.EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/Edit.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container bootstrap snippets bootdey">
        <h1 class="text-primary">Edit Profile</h1>
        <hr>
        <div class="row">
            <!-- left column -->
            <div class="col-md-3">
                <div class="text-center">
                    <asp:Image ID="Image1" runat="server" class="avatar img-circle img-thumbnail" alt="avatar" />
                    <h6>Upload a different photo...</h6>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>

            <!-- edit form column -->
            <div class="col-md-9 personal-info">
                <h3>Personal info</h3>
                <form class="form-horizontal" role="form">
                    <div class="form-group">
                        <label class="col-lg-3 control-label">First name:</label>
                        <asp:TextBox ID="txtfname" type="text" runat="server" placeholder="Enter your First name" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Last name:</label>
                        <asp:TextBox ID="txtlname" type="text" runat="server" placeholder="Enter your Last name" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-1">Gender:</label>
                        <span>
                             <label class="radio-inline">
                            <asp:RadioButton ID="male" runat="server" Text="Male" GroupName="gender" />
                        </label>
                        <label class="radio-inline">
                            <asp:RadioButton ID="female" runat="server" Text="Female" GroupName="gender" />
                        </label>
                        </span>
                       
                    </div>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Mobile:</label>
                        <asp:TextBox ID="txtmob" type="text" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Email:</label>
                        <asp:TextBox ID="txtEmail" type="text" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Password:</label>
                        <asp:TextBox ID="txtpass" type="password" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button ID="bt_profile" autopostback="true" runat="server" Text="update profile" OnClick="bt_profile_Click" />
                        <asp:Label ID="Label1" runat="server" Visible="false" Text="Data Updated!! "></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <hr>
</asp:Content>
