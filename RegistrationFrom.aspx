<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFrom.aspx.cs" Inherits="E_commerce.RegistrationFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/Registration.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="form-horizontal" role="form" style="margin-top:100px">
            <h2>Registration</h2>
            <div class="form-group">
                <label for="firstName" class="col-sm-3 control-label">First Name</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtFirst" placeholder="First Name" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="lastName" class="col-sm-3 control-label">Last Name</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtLast" placeholder="Last Name" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="email" class="col-sm-3 control-label">Admin_Email </label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtEmail" placeholder="Email" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="password" class="col-sm-3 control-label">Admin_Password</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtPassword" placeholder="Password" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="phoneNumber" class="col-sm-3 control-label">Mobile_No </label>
                <div class="col-sm-9">
                    <asp:TextBox ID="txtMobile" placeholder="Phone number" class="form-control" runat="server"></asp:TextBox>
                    <span class="help-block">Your phone number won't be disclosed anywhere </span>
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-3">Gender</label>
                <div class="col-sm-6">
                    <div class="row">
                        <div class="col-sm-4">
                            <label class="radio-inline">
                                 <asp:RadioButton ID="male" runat="server" Text="Male" GroupName="gender" />
                            </label>
                        </div>
                        <div class="col-sm-4">
                            <label class="radio-inline">
                                 <asp:RadioButton ID="female" runat="server" Text="Female" GroupName="gender" />    
                            </label>
                        </div>
                    </div>
                </div>
            </div>
             <div class="form-group">
                <label for="phoneNumber" class="col-sm-3 control-label">Pic </label>
                <div class="col-sm-9 " >
                    <asp:FileUpload ID="FileUpload1" runat="server"/>   
                </div>
            </div>
            <asp:Button type="submit" ID="btn_Register" class="btn btn-primary btn-block" runat="server" Text="Register" OnClick="btn_Register_Click" />
        </form>
    </div>
</body>
</html>
