<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGame.aspx.cs" Inherits="WebApplication.AddGame" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oyun əlavə et</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow">
                <div class="card-header bg-success text-white">
                    <h4 class="mb-0">➕ Oyun əlavə et</h4>
                </div>
                <div class="card-body">
                    <div class="row mb-3">
                        <div class="col-md-5">
                            <label for="ddlTeam1" class="form-label">Komanda 1</label>
                            <asp:DropDownList ID="ddlTeam1" runat="server" CssClass="form-select" />
                        </div>
                        <div class="col-md-1 d-flex align-items-end justify-content-center">
                            <asp:TextBox ID="txtScore1" runat="server" CssClass="form-control text-center" placeholder="0" />
                        </div>
                        <div class="col-md-1 d-flex align-items-center justify-content-center">
                            <strong>VS</strong>
                        </div>
                        <div class="col-md-1 d-flex align-items-end justify-content-center">
                            <asp:TextBox ID="txtScore2" runat="server" CssClass="form-control text-center" placeholder="0" />
                        </div>
                        <div class="col-md-5">
                            <label for="ddlTeam2" class="form-label">Komanda 2</label>
                            <asp:DropDownList ID="ddlTeam2" runat="server" CssClass="form-select" />
                        </div>
                    </div>

                    <asp:Button ID="btnAddGame" runat="server" Text="Əlavə et" CssClass="btn btn-primary" OnClick="btnAddGame_Click" />
                    <asp:Button ID="btnBackToHome" runat="server" Text="🏠 Əsas səhifəyə dön" CssClass="btn btn-secondary mt-3" OnClick="btnBackToHome_Click" />

                    <asp:Label ID="lblMessage" runat="server" CssClass="text-success ms-3" />
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
