<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="E_commerce.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div class="card text-center" style="width: 300px; margin-top: 110px">
                <div class="card-header h5 text-white bg-primary">Forget Password </div>
                <div class="card-body px-5">
                    <p class="card-text py-2">
                        Enter your email address and we'll send you an email with instructions to reset your password.
                    </p>
                    <div class="form-outline">
                        <asp:TextBox ID="txtEmail" class="form-control my-3" placeholder="Enter your Email" runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox ID="Success" runat="server" class="alert alert-success w-100" role="success" Visible="false">Email has been sent successfully</asp:TextBox>
                    <asp:TextBox ID="Alert" runat="server" class="alert alert-danger w-100" role="alert" Visible="false"> Invalid Email Details</asp:TextBox>
                    <asp:Button ID="Button1" class="btn btn-primary w-100" runat="server" Text="Reset password" OnClick="Button1_Click" />
                </div>
            </div>
    </form>
</body>
</html>
