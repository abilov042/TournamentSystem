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
                    <h4 class="mb-0">⚽ Oyun Nəticələri</h4>
                </div>
                <div class="card-body">

                    <!-- Show Form Button -->
                    <asp:Button ID="btnShowForm" runat="server" Text="➕ Oyun əlavə et" CssClass="btn btn-success mb-3" OnClick="btnShowForm_Click" />

                    <!-- Hidden Panel with Game Form -->
                    <asp:Panel ID="pnlGameForm" runat="server" Visible="false">
                        <div class="row mb-3 align-items-end">
                            <div class="col-md-4">
                                <label class="form-label">Komanda 1</label>
                                <asp:DropDownList ID="ddlTeam1" runat="server" CssClass="form-select" />
                            </div>
                            <div class="col-md-2">
                                <label class="form-label">Qol 1</label>
                                <asp:TextBox ID="txtScore1" runat="server" CssClass="form-control" TextMode="Number" />
                            </div>
                            <div class="col-md-2 text-center">
                                <strong>VS</strong>
                            </div>
                            <div class="col-md-2">
                                <label class="form-label">Qol 2</label>
                                <asp:TextBox ID="txtScore2" runat="server" CssClass="form-control" TextMode="Number" />
                            </div>
                            <div class="col-md-4">
                                <label class="form-label">Komanda 2</label>
                                <asp:DropDownList ID="ddlTeam2" runat="server" CssClass="form-select" />
                            </div>
                        </div>

                        <asp:Button ID="btnAddGame" runat="server" Text="Əlavə et" CssClass="btn btn-primary" OnClick="btnAddGame_Click" />
                        <asp:Label ID="lblMessage" runat="server" CssClass="ms-3 fw-bold" />
                        <hr />
                    </asp:Panel>

                    <!-- Grid with Game Results -->
                    <h5 class="mt-4">Əlavə olunmuş oyunlar</h5>
                    <asp:GridView ID="gvGames" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered mt-2">
                        <Columns>
                            <asp:BoundField DataField="Team1Name" HeaderText="Komanda 1" />
                            <asp:BoundField DataField="Score1" HeaderText="Qol 1" />
                            <asp:BoundField DataField="Score2" HeaderText="Qol 2" />
                            <asp:BoundField DataField="Team2Name" HeaderText="Komanda 2" />
                        </Columns>
                    </asp:GridView>

                    <!-- Back to Home -->
                    <asp:Button ID="btnBackToHome" runat="server" Text="🏠 Əsas səhifəyə dön" CssClass="btn btn-secondary mt-3" OnClick="btnBackToHome_Click" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>