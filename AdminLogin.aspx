<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="E_commerce.Admin.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Css/AdminLogin.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <div class="pt-5">
                <div class="global-container">
                    <div class="card login-form">
                        <div class="card-body">
                            <h3 class="card-title text-center">Login Form </h3>
                            <div class="card-text">
                                <div class="form-group">
                                    <label for="txtEmail">Enter Email address </label>
                                    <asp:TextBox ID="txtEmail" class="form-control form-control-sm" placeholder="Enter your Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ErrorMessage="Enter your Email" ControlToValidate="txtEmail" SetFocusOnError="true" ToolTip="Enter Email">
                                    </asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <label for="txtPass">Enter Password </label>
                                    <asp:TextBox ID="txtPass" class="form-control form-control-sm" placeholder="Enter your Password" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                        ErrorMessage="Enter Password" ControlToValidate="txtPass" SetFocusOnError="true" ToolTip="Enter Password">
                                    </asp:RequiredFieldValidator>
                                    <a href="http://localhost:53190/ForgetPassword.aspx" class="Forpass">Forgot password? </a>
                                </div>
                                <asp:TextBox ID="Alert" runat="server"  class="alert alert-danger w-100" role="alert" Visible="false"> Invalid Login Details</asp:TextBox>
                                <asp:Button ID="btn_Login" class="btn btn-primary btn-block" runat="server" Text="Login" OnClick="btn_Login_Click" />
                                <div class="sign-up">
                                    Don't have an account? <a href="http://localhost:53190/RegistrationFrom.aspx">Registration</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
