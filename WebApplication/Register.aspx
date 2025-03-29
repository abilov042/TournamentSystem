<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <!-- Bootstrap 5 CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
        }
        .register-container {
            margin-top: 100px;
        }
        .register-card {
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 15px rgba(0,0,0,0.1);
        }
    </style>
</head>
<body>
    <form id="Register" runat="server">
        <div class="container register-container">
            <div class="row justify-content-center">
                <div class="col-md-5">
                    <div class="card register-card">
                        <h3 class="text-center mb-4">Register</h3>
                        
                        <div class="mb-3">
                            <label for="txtNewUsername" class="form-label">Username</label>
                            <asp:TextBox ID="txtNewUsername" runat="server" CssClass="form-control" />
                        </div>

                        <div class="mb-3">
                            <label for="txtNewEmail" class="form-label">Email</label>
                            <asp:TextBox ID="txtNewEmail" runat="server" CssClass="form-control" />
                        </div>

                        <div class="mb-3">
                            <label for="txtNewPassword" class="form-label">Password</label>
                            <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-control" TextMode="Password" />
                        </div>

                        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-success w-100" OnClick="BtnRegister_Click" />

                        <div class="text-center mt-3">
                            <a href="Login.aspx">Back to Login</a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
