<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Turnir Cədvəli</title>

    <!-- Bootstrap 5 CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow">
                <div class="card-header bg-primary text-white">
                    <h3 class="mb-0">🏆 La Liga</h3>
                </div>
                <div class="card-body">
                    <asp:GridView ID="gvTournament" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover table-bordered" GridLines="None">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="#" />
                            <asp:BoundField DataField="TeamId" HeaderText="Komanda ID" />
                            <asp:BoundField DataField="TeamName" HeaderText="Komanda Adı" />
                            <asp:BoundField DataField="Score" HeaderText="Xal" />
                        </Columns>
                    </asp:GridView>
                </div>
                <asp:Button ID="btnAddGame" runat="server" CssClass="btn btn-success mt-3" Text="➕ Oyun əlavə et" OnClick="btnAddGame_Click" />
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
